namespace membership
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KULLANICI")]
    public partial class KULLANICI
    {
        [Key]
        public int KULLANICI_ID { get; set; }

        [StringLength(25)]
        public string USERNAME { get; set; }

        [StringLength(25)]
        public string SIFRE { get; set; }

        [StringLength(40)]
        public string UNVAN { get; set; }

        [StringLength(5)]
        public string YETKI { get; set; }

        [StringLength(11)]
        public string TCK_NO { get; set; }

        [StringLength(25)]
        public string AD { get; set; }

        [StringLength(25)]
        public string SOYAD { get; set; }
    }
}
