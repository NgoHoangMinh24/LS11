﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LHLK22CNT3Lesson11_2210900037.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NhmK22CNT3_Lesson11Entities1 : DbContext
    {
        public NhmK22CNT3_Lesson11Entities1()
            : base("name=NhmK22CNT3_Lesson11Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NhmCategory> NhmCategories { get; set; }
        public virtual DbSet<NhmProduct> NhmProducts { get; set; }
    }
}
