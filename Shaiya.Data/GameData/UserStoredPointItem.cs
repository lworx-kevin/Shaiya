namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserStoredPointItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte Slot { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte ItemCount { get; set; }

        public DateTime? BuyDate { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }
    }
}
