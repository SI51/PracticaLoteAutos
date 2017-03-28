namespace LoteAutos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autos",
                c => new
                    {
                        pkAuto = c.Int(nullable: false, identity: true),
                        sMarca = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sModeloAno = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sSerie = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sNoPlaca = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        dPrecio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sColor = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sNacionalidad = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sObservacion = c.String(maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sFotoUno = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sFotoDos = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sFotoTres = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        comprador_pkComprador = c.Int(),
                        propietario_pkPropietario = c.Int(),
                    })
                .PrimaryKey(t => t.pkAuto)
                .ForeignKey("dbo.Compradores", t => t.comprador_pkComprador)
                .ForeignKey("dbo.Propietarios", t => t.propietario_pkPropietario)
                .Index(t => t.comprador_pkComprador)
                .Index(t => t.propietario_pkPropietario);
            
            CreateTable(
                "dbo.Compradores",
                c => new
                    {
                        pkComprador = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sApePaterno = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sApeMaterno = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sCalle = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        iNumero = c.Int(nullable: false),
                        sColonia = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sCiudad = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.pkComprador);
            
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        pkDetalle = c.Int(nullable: false, identity: true),
                        dCantidad = c.Int(nullable: false),
                        auto_pkAuto = c.Int(),
                        Venta_pkVenta = c.Int(),
                    })
                .PrimaryKey(t => t.pkDetalle)
                .ForeignKey("dbo.Autos", t => t.auto_pkAuto)
                .ForeignKey("dbo.Ventas", t => t.Venta_pkVenta)
                .Index(t => t.auto_pkAuto)
                .Index(t => t.Venta_pkVenta);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        pkVenta = c.Int(nullable: false, identity: true),
                        dtFecha = c.DateTime(nullable: false, precision: 0),
                        dTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        comprador_pkComprador = c.Int(),
                    })
                .PrimaryKey(t => t.pkVenta)
                .ForeignKey("dbo.Compradores", t => t.comprador_pkComprador)
                .Index(t => t.comprador_pkComprador);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        pkPropietario = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sApePaterno = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sApeMaterno = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sCalle = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        iNumero = c.Int(nullable: false),
                        sColonia = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sCiudad = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sTelefono = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sEmail = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sIfe = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sFoto = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.pkPropietario);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        pkPermiso = c.Int(nullable: false, identity: true),
                        sModulo = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sDescripcion = c.String(maxLength: 250, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.pkPermiso);
            
            CreateTable(
                "dbo.PermisosNegadosRol",
                c => new
                    {
                        pkPermisoNegadoRol = c.Int(nullable: false, identity: true),
                        bStatus = c.Boolean(nullable: false),
                        permiso_pkPermiso = c.Int(),
                        rol_pkRol = c.Int(),
                    })
                .PrimaryKey(t => t.pkPermisoNegadoRol)
                .ForeignKey("dbo.Permisos", t => t.permiso_pkPermiso)
                .ForeignKey("dbo.Roles", t => t.rol_pkRol)
                .Index(t => t.permiso_pkPermiso)
                .Index(t => t.rol_pkRol);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        pkRol = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sDescripcion = c.String(maxLength: 250, unicode: false, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkRol);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        pkUsuario = c.Int(nullable: false, identity: true),
                        sUsuario = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        sContrasena = c.String(nullable: false, maxLength: 250, unicode: false, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PermisosNegadosRol", "rol_pkRol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegadosRol", "permiso_pkPermiso", "dbo.Permisos");
            DropForeignKey("dbo.Autos", "propietario_pkPropietario", "dbo.Propietarios");
            DropForeignKey("dbo.DetalleVentas", "Venta_pkVenta", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "comprador_pkComprador", "dbo.Compradores");
            DropForeignKey("dbo.DetalleVentas", "auto_pkAuto", "dbo.Autos");
            DropForeignKey("dbo.Autos", "comprador_pkComprador", "dbo.Compradores");
            DropIndex("dbo.PermisosNegadosRol", new[] { "rol_pkRol" });
            DropIndex("dbo.PermisosNegadosRol", new[] { "permiso_pkPermiso" });
            DropIndex("dbo.Autos", new[] { "propietario_pkPropietario" });
            DropIndex("dbo.DetalleVentas", new[] { "Venta_pkVenta" });
            DropIndex("dbo.Ventas", new[] { "comprador_pkComprador" });
            DropIndex("dbo.DetalleVentas", new[] { "auto_pkAuto" });
            DropIndex("dbo.Autos", new[] { "comprador_pkComprador" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
            DropTable("dbo.PermisosNegadosRol");
            DropTable("dbo.Permisos");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Ventas");
            DropTable("dbo.DetalleVentas");
            DropTable("dbo.Compradores");
            DropTable("dbo.Autos");
        }
    }
}
