﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxareProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_taxareEntities1 : DbContext
    {
        public db_taxareEntities1()
            : base("name=db_taxareEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Conductor> Conductors { get; set; }
        public virtual DbSet<ConductoresXtaxi> ConductoresXtaxis { get; set; }
        public virtual DbSet<GastosVariable> GastosVariables { get; set; }
        public virtual DbSet<Kilometraje> Kilometrajes { get; set; }
        public virtual DbSet<Licencia> Licencias { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Produccion> Produccions { get; set; }
        public virtual DbSet<Responsabilidade> Responsabilidades { get; set; }
        public virtual DbSet<Secretarias_transito> Secretarias_transito { get; set; }
        public virtual DbSet<SeguridadSocial> SeguridadSocials { get; set; }
        public virtual DbSet<Soat> Soats { get; set; }
        public virtual DbSet<Taxi> Taxis { get; set; }
        public virtual DbSet<Tecnomecanica> Tecnomecanicas { get; set; }
        public virtual DbSet<Toperacion> Toperacions { get; set; }
    }
}