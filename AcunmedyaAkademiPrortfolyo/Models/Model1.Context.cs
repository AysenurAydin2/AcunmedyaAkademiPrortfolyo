﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcunmedyaAkademiPrortfolyo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbAcunMedyaAkademi1Entities : DbContext
    {
        public dbAcunMedyaAkademi1Entities()
            : base("name=dbAcunMedyaAkademi1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Table_Category> Table_Category { get; set; }
        public virtual DbSet<Table_Proeject> Table_Proeject { get; set; }
        public virtual DbSet<Table_Experience> Table_Experience { get; set; }
        public virtual DbSet<Table_Education> Table_Education { get; set; }
        public virtual DbSet<Table_Message> Table_Message { get; set; }
        public virtual DbSet<Table_Service> Table_Service { get; set; }
        public virtual DbSet<Table_Testimoinal> Table_Testimoinal { get; set; }
        public virtual DbSet<TblSkill> TblSkill { get; set; }
    }
}
