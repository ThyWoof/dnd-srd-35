﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DndSrd35.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SRDEntities : DbContext
    {
        public SRDEntities()
            : base("name=SRDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<@class> classes { get; set; }
        public virtual DbSet<class_table> class_table { get; set; }
        public virtual DbSet<domain> domains { get; set; }
        public virtual DbSet<equipment> equipments { get; set; }
        public virtual DbSet<feat> feats { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<monster> monsters { get; set; }
        public virtual DbSet<power> powers { get; set; }
        public virtual DbSet<skill> skills { get; set; }
        public virtual DbSet<spell> spells { get; set; }
    }
}