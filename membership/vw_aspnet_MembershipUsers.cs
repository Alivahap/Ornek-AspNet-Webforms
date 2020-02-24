namespace membership
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_aspnet_MembershipUsers
    {
        [Key]
        [Column(Order = 0)]
        public Guid UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PasswordFormat { get; set; }

        [StringLength(16)]
        public string MobilePIN { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(256)]
        public string LoweredEmail { get; set; }

        [StringLength(256)]
        public string PasswordQuestion { get; set; }

        [StringLength(128)]
        public string PasswordAnswer { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsApproved { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsLockedOut { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime LastLoginDate { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime LastPasswordChangedDate { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime LastLockoutDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FailedPasswordAttemptCount { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime FailedPasswordAttemptWindowStart { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FailedPasswordAnswerAttemptCount { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime FailedPasswordAnswerAttemptWindowStart { get; set; }

        [Column(TypeName = "ntext")]
        public string Comment { get; set; }

        [Key]
        [Column(Order = 12)]
        public Guid ApplicationId { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(256)]
        public string UserName { get; set; }

        [StringLength(16)]
        public string MobileAlias { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool IsAnonymous { get; set; }

        [Key]
        [Column(Order = 15)]
        public DateTime LastActivityDate { get; set; }
    }
}
