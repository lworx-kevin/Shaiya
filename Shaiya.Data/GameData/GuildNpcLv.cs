namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GuildNpcLv")]
    public partial class GuildNpcLv
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GuildID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short GNpcType { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte NpcLevel { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte Number { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreateTime { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte Del { get; set; }
    }
}
