﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoDA.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelImoDaContainer : DbContext
    {
        public ModelImoDaContainer()
            : base("name=ModelImoDaContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> ClienteSet { get; set; }
        public virtual DbSet<Casa> CasaSet { get; set; }
        public virtual DbSet<Limpeza> LimpezaSet { get; set; }
        public virtual DbSet<Servico> ServicoSet { get; set; }
        public virtual DbSet<Arrendamento> ArrendamentoSet { get; set; }
        public virtual DbSet<Venda> VendaSet { get; set; }
    }
}
