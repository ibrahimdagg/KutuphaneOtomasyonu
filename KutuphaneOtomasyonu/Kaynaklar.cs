//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kaynaklar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kaynaklar()
        {
            this.ÖdünçKitaplar = new HashSet<ÖdünçKitaplar>();
        }
    
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public string KitapYazar { get; set; }
        public string KitapTür { get; set; }
        public string KitapYayınevi { get; set; }
        public Nullable<int> KitapSayfaSayısı { get; set; }
        public string KitapResim { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ÖdünçKitaplar> ÖdünçKitaplar { get; set; }
    }
}