namespace Shaiya.Data.UserData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLeaveLog")]
    public partial class UserLeaveLog
    {
        [Key]
        [Column(Order = 0)]
        public int RowID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LeaveApplyNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Status { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AppliedStatus { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(18)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string Phone1 { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(4)]
        public string Phone2 { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(4)]
        public string Phone3 { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(2000)]
        public string LeaveQuestion1 { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(2000)]
        public string LeaveQuestion2 { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(3000)]
        public string LeaveQuestion3 { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime LeaveApplyDate { get; set; }

        [Key]
        [Column(Order = 15)]
        public byte Result { get; set; }

        [StringLength(12)]
        public string ProcAdminID { get; set; }

        public DateTime? ProcDate { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool Enable { get; set; }
    }
}
