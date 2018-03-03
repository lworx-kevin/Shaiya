namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PointLog")]
    public partial class PointLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsePoint { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string ProductCode { get; set; }

        [StringLength(30)]
        public string TargetName { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime UseDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte UseType { get; set; }

        public int? RemainPoint { get; set; }

        public long? OrderNumber { get; set; }
    }
}
