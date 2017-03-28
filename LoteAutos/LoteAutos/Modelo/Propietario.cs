using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data.Entity;
using System.Data.Entity;

namespace LoteAutos.Modelo
{
    [Table("Propietarios")]
    public class Propietario
    {
        [Key]
        public int pkPropietario { get; set; }

        [Required(ErrorMessage = "Introducir nombre")]
        [StringLength(250)]
        public String sNombre { get; set; }

        [Required(ErrorMessage = "Introducir apellido paterno")]
        [StringLength(250)]
        public String sApePaterno { get; set; }

        [Required(ErrorMessage = "Introducir apellido materno")]
        [StringLength(250)]
        public String sApeMaterno { get; set; }

        [Required(ErrorMessage = "Introducir calle")]
        [StringLength(250)]
        public String sCalle { get; set; }

        [Required(ErrorMessage = "Introducir numero de casa")]
        public int iNumero { get; set; }

        [Required(ErrorMessage = "Introducir colonia")]
        [StringLength(250)]
        public String sColonia { get; set; }

        [Required(ErrorMessage = "Introducir ciudad")]
        [StringLength(250)]
        public String sCiudad { get; set; }

        [Required(ErrorMessage = "Introducir telefono")]
        [StringLength(250)]
        public String sTelefono { get; set; }

        [Required(ErrorMessage = "Introducir email")]
        [StringLength(250)]
        public String sEmail { get; set; }

        [Required(ErrorMessage = "Introducir IFE")]
        [StringLength(250)]
        public String sIfe { get; set; }

        [Required(ErrorMessage = "Introducir foto")]
        [StringLength(250)]
        public String sFoto { get; set; }

        public static List<Modelo.Propietario> GetAll()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AgregarEditar(Modelo.Propietario xPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (xPropietario.pkPropietario > 0)
                    {
                        ctx.Entry(xPropietario).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(xPropietario).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void eliminarPropietario(Propietario xPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {

                    ctx.Entry(xPropietario).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }//end class Propietario
}
