﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShaminPart4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShaminBurguersEntities : DbContext
    {
        public ShaminBurguersEntities()
            : base("name=ShaminBurguersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BasicHamburger> BasicHamburgers { get; set; }
        public virtual DbSet<DeluxeHamburger> DeluxeHamburgers { get; set; }
        public virtual DbSet<HealtyHamburger> HealtyHamburgers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}