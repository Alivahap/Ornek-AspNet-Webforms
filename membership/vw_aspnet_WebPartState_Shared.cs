namespace membership
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_aspnet_WebPartState_Shared
    {
        [Key]
        [Column(Order = 0)]
        public Guid PathId { get; set; }

        public int? DataSize { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime LastUpdatedDate { get; set; }
    }
}
