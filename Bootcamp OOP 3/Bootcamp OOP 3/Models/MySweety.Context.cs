﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bootcamp_OOP_3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class myContext : DbContext
    {
        public myContext()
            : base("name=MyContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_M_Item> TB_M_Item { get; set; }
        public virtual DbSet<TB_M_Sell> TB_M_Sell { get; set; }
        public virtual DbSet<TB_M_Suppliers> TB_M_Suppliers { get; set; }
        public virtual DbSet<TB_T_Transactions> TB_T_Transactions { get; set; }
    }
}
