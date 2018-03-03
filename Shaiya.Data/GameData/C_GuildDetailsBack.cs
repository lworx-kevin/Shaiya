namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_GuildDetailsBack")]
    public partial class C_GuildDetailsBack
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GuildID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte UseHouse { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte BuyHouse { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte Rank { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Etin { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EtinReturnCnt { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KeepEtin { get; set; }

        [StringLength(64)]
        public string Remark { get; set; }
    }
}
