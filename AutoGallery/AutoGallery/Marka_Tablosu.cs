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
    
    public partial class Marka_Tablosu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Marka_Tablosu()
        {
            this.Model_Tablosu = new HashSet<Model_Tablosu>();
        }
    
        public int Marka_Id { get; set; }
        public string Marka_Adi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Model_Tablosu> Model_Tablosu { get; set; }
    }
}
