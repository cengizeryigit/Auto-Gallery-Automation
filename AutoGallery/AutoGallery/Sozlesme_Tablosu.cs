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
    using System.Collections.Generic;
    
    public partial class Sozlesme_Tablosu
    {
        public int Sozlesme_Id { get; set; }
        public int Musteri_Id { get; set; }
        public int Arac_Id { get; set; }
        public System.DateTime Alıs_Tarihi { get; set; }
        public Nullable<System.DateTime> Veris_Tarihi { get; set; }
        public decimal Toplam_Ucret { get; set; }
        public int Sozlesme_Turu_Id { get; set; }
        public int Personel_Id { get; set; }
        public int Sube_Id { get; set; }
    
        public virtual Arac_Tablosu Arac_Tablosu { get; set; }
        public virtual Musteri_Tablosu Musteri_Tablosu { get; set; }
        public virtual Personel_Tablosu Personel_Tablosu { get; set; }
        public virtual Sozlesme_Turu_Tablosu Sozlesme_Turu_Tablosu { get; set; }
        public virtual Subeler_Tablosu Subeler_Tablosu { get; set; }
    }
}
