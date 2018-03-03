namespace Shaiya.Data.UserData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserBlockLog")]
    public partial class UserBlockLog
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(7000)]
        public string Cause { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime ProcDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(12)]
        public string ProcAdminID { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool Enable { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool AutoRelease { get; set; }
    }
}
