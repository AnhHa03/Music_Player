﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicPlayer.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NANDBEntities : DbContext
    {
        public NANDBEntities()
            : base("name=NANDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FEATUREDSONG> FEATUREDSONGs { get; set; }
        public virtual DbSet<LASTEST> LASTESTs { get; set; }
        public virtual DbSet<NEWSONG> NEWSONGs { get; set; }
        public virtual DbSet<SONG> SONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UPLOADSONG> UPLOADSONGs { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<PLAYLIST> PLAYLISTs { get; set; }
        public virtual DbSet<VIDEO> VIDEOs { get; set; }
        public virtual DbSet<UPLOADVIDEO> UPLOADVIDEOs { get; set; }
    }
}