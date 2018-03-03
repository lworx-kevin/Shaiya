namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductLog")]
    public partial class ProductLog
    {
        [Key]
        [Column(Order = 0)]
        public int RowID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte ServerID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ItemUID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Quality { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte ItemCount { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string ProductCode { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrderNumber { get; set; }

        public long? VerifyCode { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime BuyDate { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime ReceiveDate { get; set; }
    }
}
