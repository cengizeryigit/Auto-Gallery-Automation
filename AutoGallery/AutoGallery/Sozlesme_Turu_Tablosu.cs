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
    
    public partial class Sozlesme_Turu_Tablosu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sozlesme_Turu_Tablosu()
        {
            this.Sozlesme_Tablosu = new HashSet<Sozlesme_Tablosu>();
        }
    
        public int Sozlesme_Turu_Id { get; set; }
        public string Sozlesme_Turu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sozlesme_Tablosu> Sozlesme_Tablosu { get; set; }
    }
}
