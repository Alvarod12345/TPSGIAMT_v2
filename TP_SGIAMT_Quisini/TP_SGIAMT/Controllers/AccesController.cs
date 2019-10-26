using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP_SGIAMT.Models;
using System.Security.Cryptography;


namespace TP_SGIAMT.Controllers
{
    public class AccesController : Controller
    {
        public object Session { get; private set; }

        public IActionResult LogIn()
        {
            return View();
        }
        private readonly DB_A4D4D9_BDSGIAMTContext _context;

        public AccesController(DB_A4D4D9_BDSGIAMTContext context)
        {
            _context = context;
        }
  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(string txtUsuario)
        {
        
                TUsuario tuser = new TUsuario();
         
            if (txtUsuario == tuser .PkIuDni.ToString())
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Acces", "LogIn");
            }

                
            //try
            //{
            //    using ()
            //    {
            //        var oUser = (from d in db.usuario
            //                     where d.email == Usuario.Trim() && d.password == Password.Trim()
            //                     select d).FirstOrDefault();
            //        if (oUser == null)
            //        {
            //            ViewBag.Error = "Usuario o contraseña invalida";
            //            return View();
            //        }

            //        Session["User"] = oUser;

            //    }

            //    return RedirectToAction("Index", "Home");
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Error = ex.Message;
            //    return View();
            //}

        }
    }
}