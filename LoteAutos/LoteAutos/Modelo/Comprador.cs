using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Windows.Forms;

namespace LoteAutos.Modelo
{
    
    [Table("Compradores")]
    public class Comprador
    {
        #region Codigo Escrito
        [Key]
        public int pkComprador { get; set; }

        [Required(ErrorMessage ="Introducir nombre")]
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

        [Required(ErrorMessage = "Introducir numero")]
        public int iNumero { get; set; }

        [Required(ErrorMessage = "Introducir colonia")]
        [StringLength(250)]
        public String sColonia { get; set; }

        [Required(ErrorMessage = "Introducir ciudad")]
        [StringLength(250)]
        public String sCiudad { get; set; }
        #endregion

        public static List<Comprador> GetAll()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.comprador.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Guardar(Comprador nComprador)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nComprador.pkComprador > 0)
                    {
                        ctx.Entry(nComprador).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nComprador).State = EntityState.Added;
                    }
                    ctx.SaveChanges();      
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Comprador> Buscar(FILTRAR buscarPor, String Valor)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (buscarPor == FILTRAR.NOMBRE)
                    {
                        return ctx.comprador.Where(r => r.sNombre.Contains(Valor)).ToList();
                    }
                    else
                    {
                        return ctx.comprador.Where(r => r.sNombre.Contains(Valor)).ToList();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void eli(Comprador ncomprador)
        {
            try
            {
                using (var ctx = new DataModel())
                {                                         
                  
                        ctx.Entry(ncomprador).State = EntityState.Deleted;
                    
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

       

    }
    public enum FILTRAR
    {
        APELLIDO=0,
        NOMBRE=1
    }
}