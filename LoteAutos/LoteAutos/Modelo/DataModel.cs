using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LoteAutos.Modelo
{
    class DataModel : DbContext
    {
        public DataModel() : base("DataModel")
        {

        }

        public virtual DbSet<Propietario> propietarios { get; set; }
        public virtual DbSet<Auto> autos { get; set; }
        public virtual DbSet<Comprador> comprador { get; set; }
        public virtual DbSet<Rol> roles { get; set; }
        public virtual DbSet<Usuario> usuarios { get; set; }
        public virtual DbSet<Permiso> permisos { get; set; }
        public virtual DbSet<PermisosNegadosRol> permisosNegadosRol { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
