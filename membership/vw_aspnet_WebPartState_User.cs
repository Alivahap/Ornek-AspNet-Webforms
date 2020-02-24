namespace membership
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_aspnet_WebPartState_User
    {
        public Guid? PathId { get; set; }

        public Guid? UserId { get; set; }

        public int? DataSize { get; set; }

        [Key]
        public DateTime LastUpdatedDate { get; set; }
    }
}
