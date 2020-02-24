namespace membership
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OGRENCI_DEVAMSIZLIK
    {
        public int ID { get; set; }

        public int? OGRENCI_ID { get; set; }

        public int? DERS_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TARIH { get; set; }

        public virtual DERS DERS { get; set; }

        public virtual OGRENCI OGRENCI { get; set; }
    }
}
