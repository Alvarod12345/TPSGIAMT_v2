<<<<<<< HEAD
<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;



namespace TP_SGIAMT.Models
{
    [AllowAnonymous]
    public partial class TUsuario
    {
        //private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly ILogger<TUsuario> _logger;

        [BindProperty]
        public TUsuario Input { get; set; }

        //public TUsuario(SignInManager<IdentityUser> signInManager, ILogger<TUsuario> logger)
        //{
        //    _signInManager = signInManager;
        //    _logger = logger;
        //}


        [TempData]
        public String ErrorMessage { get; set; }
        //public TUsuario()
        //{
        //    TUsuarioModalidad = new HashSet<TUsuarioModalidad>();
        //} 


        //--------------DNI-------------------
        [Required(ErrorMessage = "<font color='red'>El campo DNI es obligatorio!</font>")]
        //[StringLength(100, ErrorMessage = "<font color='red'>El numero de caracteres de {0} debe ser al " +
        //    "menos {2}.</font>", MinimumLength = 8)]
        public int PkIuDni { get; set; }
        //---------------------------------

        //-------------Pass--------------------
        [Required(ErrorMessage = "<font color='red'>Contraseña es obligatorio!</font>")]
        [DataType(DataType.Password)]
        public string VuContraseña { get; set; }
        //---------------------------------

=======
=======
>>>>>>> e056b7de1e8bbc114b07a81770d351f9f890b10f
﻿using System;
using System.Collections.Generic;

namespace TP_SGIAMT.Models
{
    public partial class TUsuario
    {
        public TUsuario()
        {
<<<<<<< HEAD
            TUsuarioModalidad = new HashSet<TUsuarioModalidad>();
        }

        public int PkIuDni { get; set; }
>>>>>>> 69f5eddd531708e2401d39e31741a17cdab79439
=======
<<<<<<< HEAD
            TUsuarioModalidad = new HashSet<TUsuarioModalidad>();
=======
            TUsuarioModalidadFkIcIdConcurso1 = new HashSet<TUsuarioModalidad>();
            TUsuarioModalidadFkIuDniParejaNavigation = new HashSet<TUsuarioModalidad>();
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
        }

        public int PkIuDni { get; set; }
>>>>>>> e056b7de1e8bbc114b07a81770d351f9f890b10f
        public string VuNombre { get; set; }
        public string VuApaterno { get; set; }
        public string VuAmaterno { get; set; }
        public DateTime? DuFechaNacimiento { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD

=======
        public string VuContraseña { get; set; }
>>>>>>> 69f5eddd531708e2401d39e31741a17cdab79439
=======
        public string VuContraseña { get; set; }
>>>>>>> e056b7de1e8bbc114b07a81770d351f9f890b10f
        public string VuSexo { get; set; }
        public string VuNacademia { get; set; }
        public int? FkIuCodCategoria { get; set; }
        public int? FkItuTipoUsuario { get; set; }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e056b7de1e8bbc114b07a81770d351f9f890b10f
        public int? FkIauIdArchivo { get; set; }

        public TArchivoUsuario FkIauIdArchivoNavigation { get; set; }
        public TTipoUsuario FkItuTipoUsuarioNavigation { get; set; }
        public TCategoria FkIuCodCategoriaNavigation { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidad { get; set; }
<<<<<<< HEAD
=======
=======

        public TTipoUsuario FkItuTipoUsuarioNavigation { get; set; }
        public TCategoria FkIuCodCategoriaNavigation { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidadFkIcIdConcurso1 { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidadFkIuDniParejaNavigation { get; set; }
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
>>>>>>> e056b7de1e8bbc114b07a81770d351f9f890b10f
    }
}
