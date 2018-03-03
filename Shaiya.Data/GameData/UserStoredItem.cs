namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserStoredItem
    {
        [Key]
        [Column(Order = 0)]
        public int RowID { get; set; }

        public byte? ServerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte Type { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte TypeID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ItemUID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Slot { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Quality { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte Gem1 { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte Gem2 { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte Gem3 { get; set; }

        [Key]
        [Column(Order = 11)]
        public byte Gem4 { get; set; }

        [Key]
        [Column(Order = 12)]
        public byte Gem5 { get; set; }

        [Key]
        [Column(Order = 13)]
        public byte Gem6 { get; set; }

        [StringLength(20)]
        public string Craftname { get; set; }

        [Key]
        [Column(Order = 14)]
        public byte Count { get; set; }

        [Key]
        [Column(Order = 15)]
        public DateTime Maketime { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(1)]
        public string Maketype { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool Del { get; set; }
    }
}
