//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoGallery
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutoGalleryEntity : DbContext
    {
        public AutoGalleryEntity()
            : base("name=AutoGalleryEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arac_Durumu_Tablosu> Arac_Durumu_Tablosu { get; set; }
        public virtual DbSet<Arac_Tablosu> Arac_Tablosu { get; set; }
        public virtual DbSet<Marka_Tablosu> Marka_Tablosu { get; set; }
        public virtual DbSet<Model_Tablosu> Model_Tablosu { get; set; }
        public virtual DbSet<Musteri_Tablosu> Musteri_Tablosu { get; set; }
        public virtual DbSet<Personel_Tablosu> Personel_Tablosu { get; set; }
        public virtual DbSet<Personel_Turu_Tablosu> Personel_Turu_Tablosu { get; set; }
        public virtual DbSet<Sozlesme_Tablosu> Sozlesme_Tablosu { get; set; }
        public virtual DbSet<Sozlesme_Turu_Tablosu> Sozlesme_Turu_Tablosu { get; set; }
        public virtual DbSet<Subeler_Tablosu> Subeler_Tablosu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
