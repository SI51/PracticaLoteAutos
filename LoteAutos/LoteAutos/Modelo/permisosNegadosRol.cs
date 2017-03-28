using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoteAutos.Modelo
{
    [Table("PermisosNegadosRol")]
    public class PermisosNegadosRol
    {
        [Key]
        public int pkPermisoNegadoRol { get; set; }

        public Boolean bStatus { get; set; }

        public PermisosNegadosRol()
        {
            this.bStatus = true;
        }

        public virtual Permiso permiso { get; set; }
        public virtual Rol rol { get; set; } 
    }
}
