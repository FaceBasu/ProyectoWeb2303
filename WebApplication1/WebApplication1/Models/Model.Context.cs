﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_MARYSTYLISEntities : DbContext
    {
        public BD_MARYSTYLISEntities()
            : base("name=BD_MARYSTYLISEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Detalle_Ganancias_Facturas> Detalle_Ganancias_Facturas { get; set; }
        public virtual DbSet<DetalleFacturaProducto> DetalleFacturaProducto { get; set; }
        public virtual DbSet<DetalleFacturaServicios> DetalleFacturaServicios { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<GananciaDiaria> GananciaDiaria { get; set; }
        public virtual DbSet<ImagenesProductos> ImagenesProductos { get; set; }
        public virtual DbSet<ImagenesServicios> ImagenesServicios { get; set; }
        public virtual DbSet<Planilla> Planilla { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<PromocionesProductos> PromocionesProductos { get; set; }
        public virtual DbSet<PromocionesServicios> PromocionesServicios { get; set; }
        public virtual DbSet<Reseñas> Reseñas { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
