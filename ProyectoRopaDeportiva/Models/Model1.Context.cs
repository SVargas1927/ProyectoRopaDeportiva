﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoRopaDeportiva.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DesarrolloWebEntities : DbContext
    {
        public DesarrolloWebEntities()
            : base("name=DesarrolloWebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientesR> ClientesR { get; set; }
        public virtual DbSet<DetalleVR> DetalleVR { get; set; }
        public virtual DbSet<OrdenesR> OrdenesR { get; set; }
        public virtual DbSet<VendedoresR> VendedoresR { get; set; }
        public virtual DbSet<DetallesOR> DetallesOR { get; set; }
        public virtual DbSet<ProductosR> ProductosR { get; set; }
        public virtual DbSet<VentasR> VentasR { get; set; }
    }
}
