using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP_SGIAMT.Models;

namespace TP_SGIAMT.Controllers
{
    public class TUsuariosController : Controller
    {
<<<<<<< HEAD
        private readonly DB_A4D4D9_BDSGIAMTContext _context;

        public TUsuariosController(DB_A4D4D9_BDSGIAMTContext context)
=======
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TUsuariosController(DB_A4F05E_SGIAMTPContext context)
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
        {
            _context = context;
        }

        // GET: TUsuarios
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            var dB_A4D4D9_BDSGIAMTContext = _context.TUsuario.Include(t => t.FkIauIdArchivoNavigation).Include(t => t.FkItuTipoUsuarioNavigation).Include(t => t.FkIuCodCategoriaNavigation);
            return View(await dB_A4D4D9_BDSGIAMTContext.ToListAsync());
=======
            var dB_A4F05E_SGIAMTPContext = _context.TUsuario.Include(t => t.FkItuTipoUsuarioNavigation).Include(t => t.FkIuCodCategoriaNavigation);
            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
        }

        // GET: TUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuario = await _context.TUsuario
<<<<<<< HEAD
                .Include(t => t.FkIauIdArchivoNavigation)
=======
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
                .Include(t => t.FkItuTipoUsuarioNavigation)
                .Include(t => t.FkIuCodCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.PkIuDni == id);
            if (tUsuario == null)
            {
                return NotFound();
            }

            return View(tUsuario);
        }

        // GET: TUsuarios/Create
        public IActionResult Create()
        {
<<<<<<< HEAD
            ViewData["FkIauIdArchivo"] = new SelectList(_context.TArchivoUsuario, "PkIauIdArchivo", "PkIauIdArchivo");
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario");
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "PkIcCodCat");
=======
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario");
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "VcNomCategoria");
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
            return View();
        }

        // POST: TUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("PkIuDni,VuNombre,VuApaterno,VuAmaterno,DuFechaNacimiento,VuContraseña,VuSexo,VuNacademia,FkIuCodCategoria,FkItuTipoUsuario,FkIauIdArchivo")] TUsuario tUsuario)
=======
        public async Task<IActionResult> Create([Bind("PkIuDni,VuNombre,VuApaterno,VuAmaterno,DuFechaNacimiento,VuContraseña,VuSexo,VuNacademia,FkIuCodCategoria,FkItuTipoUsuario")] TUsuario tUsuario)
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
        {
            if (ModelState.IsValid)
            {
                _context.Add(tUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
<<<<<<< HEAD
            ViewData["FkIauIdArchivo"] = new SelectList(_context.TArchivoUsuario, "PkIauIdArchivo", "PkIauIdArchivo", tUsuario.FkIauIdArchivo);
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario", tUsuario.FkItuTipoUsuario);
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "PkIcCodCat", tUsuario.FkIuCodCategoria);
=======
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario", tUsuario.FkItuTipoUsuario);
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "VcNomCategoria", tUsuario.FkIuCodCategoria);
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
            return View(tUsuario);
        }

        // GET: TUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuario = await _context.TUsuario.FindAsync(id);
            if (tUsuario == null)
            {
                return NotFound();
            }
<<<<<<< HEAD
            ViewData["FkIauIdArchivo"] = new SelectList(_context.TArchivoUsuario, "PkIauIdArchivo", "PkIauIdArchivo", tUsuario.FkIauIdArchivo);
=======
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario", tUsuario.FkItuTipoUsuario);
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "PkIcCodCat", tUsuario.FkIuCodCategoria);
            return View(tUsuario);
        }

        // POST: TUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(int id, [Bind("PkIuDni,VuNombre,VuApaterno,VuAmaterno,DuFechaNacimiento,VuContraseña,VuSexo,VuNacademia,FkIuCodCategoria,FkItuTipoUsuario,FkIauIdArchivo")] TUsuario tUsuario)
=======
        public async Task<IActionResult> Edit(int id, [Bind("PkIuDni,VuNombre,VuApaterno,VuAmaterno,DuFechaNacimiento,VuContraseña,VuSexo,VuNacademia,FkIuCodCategoria,FkItuTipoUsuario")] TUsuario tUsuario)
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
        {
            if (id != tUsuario.PkIuDni)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TUsuarioExists(tUsuario.PkIuDni))
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
<<<<<<< HEAD
            ViewData["FkIauIdArchivo"] = new SelectList(_context.TArchivoUsuario, "PkIauIdArchivo", "PkIauIdArchivo", tUsuario.FkIauIdArchivo);
=======
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario", tUsuario.FkItuTipoUsuario);
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "PkIcCodCat", tUsuario.FkIuCodCategoria);
            return View(tUsuario);
        }

        // GET: TUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuario = await _context.TUsuario
<<<<<<< HEAD
                .Include(t => t.FkIauIdArchivoNavigation)
=======
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
                .Include(t => t.FkItuTipoUsuarioNavigation)
                .Include(t => t.FkIuCodCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.PkIuDni == id);
            if (tUsuario == null)
            {
                return NotFound();
            }

            return View(tUsuario);
        }

        // POST: TUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tUsuario = await _context.TUsuario.FindAsync(id);
            _context.TUsuario.Remove(tUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TUsuarioExists(int id)
        {
            return _context.TUsuario.Any(e => e.PkIuDni == id);
        }
    }
}
