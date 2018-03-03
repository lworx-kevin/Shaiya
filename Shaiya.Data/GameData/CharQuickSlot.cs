namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CharQuickSlot
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte QuickBar { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte QuickSlot { get; set; }

        public byte Bag { get; set; }

        public byte Number { get; set; }
    }
}
