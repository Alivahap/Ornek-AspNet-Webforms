namespace membership
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OGRENCI")]
    public partial class OGRENCI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OGRENCI()
        {
            OGRENCI_DEVAMSIZLIK = new HashSet<OGRENCI_DEVAMSIZLIK>();
        }

        [Key]
        public int OGRENCI_ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(4)]
        public string OGRENCI_NO { get; set; }

        [StringLength(11)]
        public string TCK_NO { get; set; }

        [StringLength(25)]
        public string AD { get; set; }

        [StringLength(25)]
        public string SOYAD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOGUM_TARIHI { get; set; }

        [StringLength(1)]
        public string CINSIYET { get; set; }

        [StringLength(2)]
        public string SINIF { get; set; }

        [StringLength(5)]
        public string DEVAM { get; set; }

        [StringLength(255)]
        public string DOSYA_PATH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OGRENCI_DEVAMSIZLIK> OGRENCI_DEVAMSIZLIK { get; set; }
    }
}
