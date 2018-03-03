namespace Shaiya.Data.UserData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPauseLog")]
    public partial class UserPauseLog
    {
        [Key]
        [Column(Order = 0)]
        public int RowID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Status { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AppliedStatus { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(7000)]
        public string Cause { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ProcDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(12)]
        public string ProcAdminID { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool Enable { get; set; }
    }
}
