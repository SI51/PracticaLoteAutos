using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoteAutos.Modelo
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        public int pkPermiso { get; set; }

        [Required(ErrorMessage ="Introducir modulo")]
        [StringLength(250)]
        public String sModulo { get; set; }

        [StringLength(250)]
        public String sDescripcion { get; set; }

        public ICollection<PermisosNegadosRol> permisoNegadoRol { get; set; }
    }
}
