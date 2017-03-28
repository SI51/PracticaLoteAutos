using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoteAutos.Modelo
{
    [Table("Autos")]
    public class Auto
    {
        [Key]
        public int pkAuto { get; set; }

        [Required(ErrorMessage ="Introducir marca")]
        [StringLength(250)]
        public String sMarca { get; set; }

        [Required(ErrorMessage = "Introducir año del modelo")]
        [StringLength(250)]
        public String sModeloAno { get; set; }

        [Required(ErrorMessage = "Introducir serie")]
        [StringLength(250)]
        public String sSerie { get; set; }

        [Required(ErrorMessage = "Introducir numero de placa")]
        [StringLength(250)]
        public String sNoPlaca { get; set; }

        [Required(ErrorMessage = "Introducir precio")]
        public decimal dPrecio { get; set; }

        [Required(ErrorMessage = "Introducir color")]
        [StringLength(250)]
        public String sColor { get; set; }

        [Required(ErrorMessage = "Introducir nacionalidad")]
        [StringLength(250)]
        public String sNacionalidad { get; set; }

        [StringLength(250)]
        public String sObservacion { get; set; }

        [Required(ErrorMessage = "Introducir foto uno")]
        [StringLength(250)]
        public String sFotoUno { get; set; }

        [Required(ErrorMessage = "Introducir foto dos")]
        [StringLength(250)]
        public String sFotoDos { get; set; }

        [Required(ErrorMessage = "Introducir foto tres")]
        [StringLength(250)]
        public String sFotoTres { get; set; }

        public virtual Propietario propietario { get; set; }
        public virtual Comprador comprador { get; set; }
        public ICollection<DetalleVenta> detalleVenta { get; set; }
    }
}
