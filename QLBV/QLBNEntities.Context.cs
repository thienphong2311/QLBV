﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBV
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLBNEntities2 : DbContext
    {
        public QLBNEntities2()
            : base("name=QLBNEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CT_KQXN> CT_KQXN { get; set; }
        public virtual DbSet<KQXN> KQXNs { get; set; }
        public virtual DbSet<TT_BenhNhan> TT_BenhNhan { get; set; }
    }
}
