﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP_SGIAMT.Models;

namespace TP_SGIAMT.Controllers
{
    public class TConcursoesController : Controller
    {
        private readonly DB_A4D4D9_BDSGIAMTContext _context;

        public TConcursoesController(DB_A4D4D9_BDSGIAMTContext context)
        {
            _context = context;
        }


        // GET: TConcursoes
        public async Task<IActionResult> Index()
        {
            var dB_A4D4D9_BDSGIAMTContext = _context.TConcurso.Include(t => t.FkIecIdEstadoNavigation);
            return View(await dB_A4D4D9_BDSGIAMTContext.ToListAsync());
        }

        // GET: TConcursoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tConcurso = await _context.TConcurso
                .Include(t => t.FkIecIdEstadoNavigation)
                .FirstOrDefaultAsync(m => m.PkIcIdConcurso == id);
            if (tConcurso == null)
            {
                return NotFound();
            }

            return View(tConcurso);
        }

        // GET: TConcursoes/Create
        public IActionResult Create()
        {
            ViewData["FkIecIdEstado"] = new SelectList(_context.TEstadoCon, "PkIeIdEstado", "VeNombreEsta");
            return View();
        }

        // POST: TConcursoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIcIdConcurso,VcNombreCon,VcLugarCon,DcFechaConcurso,FkIecIdEstado,IcCantidadSeri,IcCantidadNove")] TConcurso tConcurso)
        {
            //int id;
            bool Isnomconexist = _context.TConcurso.Any
              (x => x.VcNombreCon == tConcurso.VcNombreCon);
            if (Isnomconexist == true)
            {
                ModelState.AddModelError("VcNombreCon", "ya existe este Nombre");
            }

            bool Isfechaconnexist = _context.TConcurso.Any
             (x => x.DcFechaConcurso == tConcurso.DcFechaConcurso);
            if (Isfechaconnexist == true)
            {
                ModelState.AddModelError("DcFechaConcurso", "Fecha No Permitida");
            }

            bool Isfechacnexist = _context.TConcurso.Any
             (x => DateTime.Now >= tConcurso.DcFechaConcurso);
            if (Isfechacnexist == true)
            {
                ModelState.AddModelError("DcFechaConcurso", "Fecha No Permitida");
            }

            bool Iscantsexist = _context.TConcurso.Any
             (x => 50 <= tConcurso.IcCantidadSeri);
            if (Iscantsexist == true)
            {
                ModelState.AddModelError("IcCantidadSeri", "Cantidad No Permitida");
            }

            bool Iscantnexist = _context.TConcurso.Any
            (x => 50 <= tConcurso.IcCantidadNove);
            if (Iscantnexist == true)
            {
                ModelState.AddModelError("IcCantidadNove", "Cantidad No Permitida");
            }

            if (ModelState.IsValid)
            {
                tConcurso.FkIecIdEstado = 1;
                _context.Add(tConcurso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            //ViewData["FkIecIdEstado"] = new SelectList(_context.TEstadoCon, "PkIeIdEstado", "VeNombreEsta", tConcurso.FkIecIdEstado);
            return View(tConcurso);
        }

        // GET: TConcursoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tConcurso = await _context.TConcurso.FindAsync(id);
            if (tConcurso == null)
            {
                return NotFound();
            }
            ViewData["FkIecIdEstado"] = new SelectList(_context.TEstadoCon, "PkIeIdEstado", "VeNombreEsta", tConcurso.FkIecIdEstado);
            return View(tConcurso);
        }

        // POST: TConcursoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkIcIdConcurso,VcNombreCon,VcLugarCon,DcFechaConcurso,FkIecIdEstado,IcCantidadSeri,IcCantidadNove")] TConcurso tConcurso)
        {
            if (id != tConcurso.PkIcIdConcurso)
            {
                return NotFound();
            }

            bool Isfechacnexist = _context.TConcurso.Any
             (x => DateTime.Now >= tConcurso.DcFechaConcurso);
            if (Isfechacnexist == true)
            {
                ModelState.AddModelError("DcFechaConcurso", "Fecha No Permitida");
            }
            

            bool Iscantsexist = _context.TConcurso.Any
             (x => 51 <= tConcurso.IcCantidadSeri);
            if (Iscantsexist == true)
            {
                ModelState.AddModelError("IcCantidadSeri", "Cantidad No Permitida");
            }

            bool Iscantnexist = _context.TConcurso.Any
            (x => 51 <= tConcurso.IcCantidadNove);
            if (Iscantnexist == true)
            {
                ModelState.AddModelError("IcCantidadNove", "Cantidad No Permitida");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tConcurso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TConcursoExists(tConcurso.PkIcIdConcurso))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkIecIdEstado"] = new SelectList(_context.TEstadoCon, "PkIeIdEstado", "VeNombreEsta", tConcurso.FkIecIdEstado);
            return View(tConcurso);
        }

        // GET: TConcursoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tConcurso = await _context.TConcurso
                .Include(t => t.FkIecIdEstadoNavigation)
                .FirstOrDefaultAsync(m => m.PkIcIdConcurso == id);
            if (tConcurso == null)
            {
                return NotFound();
            }

            return View(tConcurso);
        }

        // POST: TConcursoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tConcurso = await _context.TConcurso.FindAsync(id);
            _context.TConcurso.Remove(tConcurso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TConcursoExists(int id)
        {
            return _context.TConcurso.Any(e => e.PkIcIdConcurso == id);
        }
    }
}
