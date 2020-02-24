namespace membership
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_aspnet_Roles
    {
        [Key]
        [Column(Order = 0)]
        public Guid ApplicationId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RoleId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string RoleName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(256)]
        public string LoweredRoleName { get; set; }

        [StringLength(256)]
        public string Description { get; set; }
    }
}
