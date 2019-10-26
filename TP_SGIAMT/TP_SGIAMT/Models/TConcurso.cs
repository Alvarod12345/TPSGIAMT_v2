using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_SGIAMT.Models
{
    public partial class TConcurso
    {
        public int PkIcIdConcurso { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "minimo 8 caracteres")]
        //[Index(Isunique = true)]
        public string VcNombreCon { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string VcLugarCon { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime? DcFechaConcurso { get; set; }
        public int? FkIecIdEstado { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"[1-9]+[10-99]", ErrorMessage = "Solo Números Positivos")]
        public int? IcCantidadSeri { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"[1-9]+[10-99]", ErrorMessage = "Solo Números Positivos")]
        public int? IcCantidadNove { get; set; }

        public TEstadoCon FkIecIdEstadoNavigation { get; set; }
    }
}
