using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LoteAutos.Modelo
{
    [Table("Roles")]
    public class Rol
    {
        [Key]
        public int pkRol { get; set; }

        [Required(ErrorMessage ="Introducir nombre")]
        [StringLength(250)]
        public String sNombre { get; set; }

        [StringLength(250)]
        public String sDescripcion { get; set; }

        public Boolean bStatus { get; set; }

        public Rol()
        {
            this.bStatus = true;
        }        

        public static List<Rol> GetAll()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AgregarEditar(Rol xRol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (xRol.pkRol > 0)
                    {
                        ctx.Entry(xRol).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(xRol).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void eliminarRol(Rol xRol)
        {
            try
            {
                using (var ctx = new DataModel())
                {

                    ctx.Entry(xRol).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }//end class Rol
}
