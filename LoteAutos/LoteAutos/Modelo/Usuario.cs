using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoteAutos.Modelo
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int pkUsuario { get; set; }

        [Required(ErrorMessage ="Introducir usuario")]
        [StringLength(250)]
        public String sUsuario { get; set; }

        [Required(ErrorMessage ="Contraseña obligatoria")]
        [StringLength(250)]
        public String sContrasena { get; set; }

        public Boolean bStatus { get; set; }

        public Usuario()
        {
            this.bStatus = true;
        }
    }
}
