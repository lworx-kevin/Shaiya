namespace Shaiya.Data.UserData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users_Master
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Required]
        [StringLength(18)]
        public string UserID { get; set; }

        [Required]
        [StringLength(32)]
        public string Pw { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime JoinDate { get; set; }

        public bool Admin { get; set; }

        public byte AdminLevel { get; set; }

        public bool UseQueue { get; set; }

        public short Status { get; set; }

        public byte Leave { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LeaveDate { get; set; }

        [Required]
        [StringLength(1)]
        public string UserType { get; set; }

        [StringLength(15)]
        public string UserIp { get; set; }

        [StringLength(15)]
        public string ModiIp { get; set; }

        public DateTime? ModiDate { get; set; }

        public int Point { get; set; }

        [StringLength(50)]
        public string Enpassword { get; set; }

        [StringLength(8)]
        public string Birth { get; set; }
    }
}
