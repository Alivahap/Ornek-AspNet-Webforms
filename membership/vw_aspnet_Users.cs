namespace membership
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_aspnet_Users
    {
        [Key]
        [Column(Order = 0)]
        public Guid ApplicationId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(256)]
        public string LoweredUserName { get; set; }

        [StringLength(16)]
        public string MobileAlias { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsAnonymous { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime LastActivityDate { get; set; }
    }
}
