using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoteAutos.Modelo
{
    [Table("Ventas")]
    public class Venta
    {
        [Key]
        public int pkVenta { get; set; }

        [Required(ErrorMessage = "Introducir fecha")]
        public DateTime dtFecha { get; set; }

        public Decimal dTotal { get; set; }

        public virtual Comprador comprador { get; set; }
        public ICollection<DetalleVenta> detalleVenta { get; set; }
    }
}
