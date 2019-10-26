using System;
using System.Collections.Generic;

namespace TP_SGIAMT.Models
{
    public partial class TUsuario
    {
        public TUsuario()
        {
<<<<<<< HEAD
            TUsuarioModalidad = new HashSet<TUsuarioModalidad>();
=======
            TUsuarioModalidadFkIcIdConcurso1 = new HashSet<TUsuarioModalidad>();
            TUsuarioModalidadFkIuDniParejaNavigation = new HashSet<TUsuarioModalidad>();
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
        }

        public int PkIuDni { get; set; }
        public string VuNombre { get; set; }
        public string VuApaterno { get; set; }
        public string VuAmaterno { get; set; }
        public DateTime? DuFechaNacimiento { get; set; }
        public string VuContraseña { get; set; }
        public string VuSexo { get; set; }
        public string VuNacademia { get; set; }
        public int? FkIuCodCategoria { get; set; }
        public int? FkItuTipoUsuario { get; set; }
<<<<<<< HEAD
        public int? FkIauIdArchivo { get; set; }

        public TArchivoUsuario FkIauIdArchivoNavigation { get; set; }
        public TTipoUsuario FkItuTipoUsuarioNavigation { get; set; }
        public TCategoria FkIuCodCategoriaNavigation { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidad { get; set; }
=======

        public TTipoUsuario FkItuTipoUsuarioNavigation { get; set; }
        public TCategoria FkIuCodCategoriaNavigation { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidadFkIcIdConcurso1 { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidadFkIuDniParejaNavigation { get; set; }
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
    }
}
