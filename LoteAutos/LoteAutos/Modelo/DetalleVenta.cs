using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoteAutos.Modelo
{
    [Table("DetalleVentas")]
    public class DetalleVenta
    {
        [Key]
        public int pkDetalle { get; set; }

        [Required(ErrorMessage ="Introducir cantidad")]
        public int dCantidad { get; set; }

        public virtual Auto auto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
