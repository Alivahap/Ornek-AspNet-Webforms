namespace membership
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DERS()
        {
            OGRENCI_DEVAMSIZLIK = new HashSet<OGRENCI_DEVAMSIZLIK>();
        }

        [Key]
        public int DERS_ID { get; set; }

        [StringLength(50)]
        public string DERS_AD { get; set; }

        [StringLength(255)]
        public string ACIKLAMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OGRENCI_DEVAMSIZLIK> OGRENCI_DEVAMSIZLIK { get; set; }
    }
}
