namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHARS")]
    public partial class Character
    {
        [Key]
        [Column(Order = 0)]
        public byte ServerID { get; set; }

        public int UserUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int CharID { get; set; }

        [Required]
        [StringLength(30)]
        public string CharName { get; set; }

        public byte? New { get; set; }

        public byte? Del { get; set; }

        public byte Slot { get; set; }

        public byte Family { get; set; }

        public byte Grow { get; set; }

        public byte Hair { get; set; }

        public byte Face { get; set; }

        public byte Size { get; set; }

        public byte Job { get; set; }

        public byte Sex { get; set; }

        public short? Level { get; set; }

        public short? StatPoint { get; set; }

        public short? SkillPoint { get; set; }

        public short Str { get; set; }

        public short Dex { get; set; }

        public short Rec { get; set; }

        public short Int { get; set; }

        public short Luc { get; set; }

        public short Wis { get; set; }

        public short HP { get; set; }

        public short MP { get; set; }

        public short SP { get; set; }

        public short? Map { get; set; }

        public short? Dir { get; set; }

        public int? Exp { get; set; }

        public int? Money { get; set; }

        public float? PosX { get; set; }

        public float? PosY { get; set; }

        public float? Posz { get; set; }

        public short Hg { get; set; }

        public short Vg { get; set; }

        public byte Cg { get; set; }

        public byte Og { get; set; }

        public byte Ig { get; set; }

        public int? K1 { get; set; }

        public int? K2 { get; set; }

        public int? K3 { get; set; }

        public int? K4 { get; set; }

        public byte? KillLevel { get; set; }

        public byte? DeadLevel { get; set; }

        public DateTime? RegDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public DateTime? JoinDate { get; set; }

        public DateTime? LeaveDate { get; set; }

        public byte RenameCnt { get; set; }

        [StringLength(30)]
        public string OldCharName { get; set; }

        public int? RemainTime { get; set; }

        public bool DeleteRequest { get; set; }

        public byte? LoginStatus { get; set; }

        public byte? Kill { get; set; }

        public bool UMReset { get; set; }
    }
}
