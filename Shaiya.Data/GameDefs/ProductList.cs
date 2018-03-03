namespace Shaiya.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductList")]
    public partial class ProductList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductCode { get; set; }

        public int BuyCost { get; set; }

        public int ItemID1 { get; set; }

        public byte ItemCount1 { get; set; }

        public int? ItemID2 { get; set; }

        public byte? ItemCount2 { get; set; }

        public int? ItemID3 { get; set; }

        public byte? ItemCount3 { get; set; }

        public int? ItemID4 { get; set; }

        public byte? ItemCount4 { get; set; }

        public int? ItemID5 { get; set; }

        public byte? ItemCount5 { get; set; }

        public int? ItemID6 { get; set; }

        public byte? ItemCount6 { get; set; }

        public int? ItemID7 { get; set; }

        public byte? ItemCount7 { get; set; }

        public int? ItemID8 { get; set; }

        public byte? ItemCount8 { get; set; }

        public int? ItemID9 { get; set; }

        public byte? ItemCount9 { get; set; }

        public int? ItemID10 { get; set; }

        public byte? ItemCount10 { get; set; }

        public int? ItemID11 { get; set; }

        public byte? ItemCount11 { get; set; }

        public int? ItemID12 { get; set; }

        public byte? ItemCount12 { get; set; }

        public int? ItemID13 { get; set; }

        public byte? ItemCount13 { get; set; }

        public int? ItemID14 { get; set; }

        public byte? ItemCount14 { get; set; }

        public int? ItemID15 { get; set; }

        public byte? ItemCount15 { get; set; }

        public int? ItemID16 { get; set; }

        public byte? ItemCount16 { get; set; }

        public int? ItemID17 { get; set; }

        public byte? ItemCount17 { get; set; }

        public int? ItemID18 { get; set; }

        public byte? ItemCount18 { get; set; }

        public int? ItemID19 { get; set; }

        public byte? ItemCount19 { get; set; }

        public int? ItemID20 { get; set; }

        public byte? ItemCount20 { get; set; }

        public int? ItemID21 { get; set; }

        public byte? ItemCount21 { get; set; }

        public int? ItemID22 { get; set; }

        public byte? ItemCount22 { get; set; }

        public int? ItemID23 { get; set; }

        public byte? ItemCount23 { get; set; }

        public int? ItemID24 { get; set; }

        public byte? ItemCount24 { get; set; }
    }
}
