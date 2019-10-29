using System;
using System.Collections.Generic;

namespace TP_SGIAMT.Models
{
    public partial class TUsuarioModalidad
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e056b7de1e8bbc114b07a81770d351f9f890b10f
        public int? FkIuDni { get; set; }
        public int? FkImIdModalidad { get; set; }
        public int PkIumCodUm { get; set; }
        public int? FkIcIdConcurso { get; set; }

        public TConcurso FkIcIdConcursoNavigation { get; set; }
        public TModalidadCon FkImIdModalidadNavigation { get; set; }
        public TUsuario FkIuDniNavigation { get; set; }
<<<<<<< HEAD
=======
=======
        public TUsuarioModalidad()
        {
            TUsuarioModalidadTanda = new HashSet<TUsuarioModalidadTanda>();
        }

        public int PkIumCodUm { get; set; }
        public int? FkIuDni { get; set; }
        public int? FkIcIdConcurso { get; set; }
        public int? FkImIdModalidad { get; set; }
        public int? IumFase { get; set; }
        public int? FkIuDniPareja { get; set; }
        public DateTime? DumFechaIns { get; set; }
        public string VmUmArchivoDni { get; set; }
        public string VmUmArchivoB { get; set; }

        public TUsuario FkIcIdConcurso1 { get; set; }
        public TConcurso FkIcIdConcursoNavigation { get; set; }
        public TModalidadCon FkImIdModalidadNavigation { get; set; }
        public TUsuario FkIuDniParejaNavigation { get; set; }
        public ICollection<TUsuarioModalidadTanda> TUsuarioModalidadTanda { get; set; }
>>>>>>> e9211f248a17aee8ccf3b737935e5b1897a29fdd
>>>>>>> e056b7de1e8bbc114b07a81770d351f9f890b10f
    }
}
