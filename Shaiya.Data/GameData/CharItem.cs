namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CharItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ItemUID { get; set; }

        public int ItemID { get; set; }

        public byte Type { get; set; }

        public byte TypeID { get; set; }

        public byte Bag { get; set; }

        public byte Slot { get; set; }

        public short Quality { get; set; }

        public byte Gem1 { get; set; }

        public byte Gem2 { get; set; }

        public byte Gem3 { get; set; }

        public byte Gem4 { get; set; }

        public byte Gem5 { get; set; }

        public byte Gem6 { get; set; }

        [StringLength(20)]
        public string Craftname { get; set; }

        public byte Count { get; set; }

        public DateTime Maketime { get; set; }

        [Required]
        [StringLength(1)]
        public string Maketype { get; set; }

        public bool Del { get; set; }
    }
}
