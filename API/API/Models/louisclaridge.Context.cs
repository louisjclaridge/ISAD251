﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMIN> ADMINs { get; set; }
        public virtual DbSet<APPLICATION> APPLICATIONs { get; set; }
        public virtual DbSet<COMPANY> COMPANies { get; set; }
        public virtual DbSet<JOB> JOBs { get; set; }
        public virtual DbSet<PROGRAMME> PROGRAMMEs { get; set; }
        public virtual DbSet<SITE> SITES { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }
    }
}
