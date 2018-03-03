namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PointGiftNotify")]
    public partial class PointGiftNotify
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ProductCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string SendCharName { get; set; }

        public DateTime? RecvDate { get; set; }
    }
}
