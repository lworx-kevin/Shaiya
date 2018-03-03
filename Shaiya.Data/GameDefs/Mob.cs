namespace Shaiya.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mob
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MobID { get; set; }

        [Required]
        [StringLength(40)]
        public string MobName { get; set; }

        public short Level { get; set; }

        public short Exp { get; set; }

        public byte AI { get; set; }

        public short Money1 { get; set; }

        public short Money2 { get; set; }

        public int QuestItemID { get; set; }

        public int HP { get; set; }

        public short SP { get; set; }

        public short MP { get; set; }

        public short Dex { get; set; }

        public short Wis { get; set; }

        public short Luc { get; set; }

        public byte Day { get; set; }

        public byte Size { get; set; }

        public byte Attrib { get; set; }

        public short Defense { get; set; }

        public short Magic { get; set; }

        public byte ResistState1 { get; set; }

        public byte ResistState2 { get; set; }

        public byte ResistState3 { get; set; }

        public byte ResistState4 { get; set; }

        public byte ResistState5 { get; set; }

        public byte ResistState6 { get; set; }

        public byte ResistState7 { get; set; }

        public byte ResistState8 { get; set; }

        public byte ResistState9 { get; set; }

        public byte ResistState10 { get; set; }

        public byte ResistState11 { get; set; }

        public byte ResistState12 { get; set; }

        public byte ResistState13 { get; set; }

        public byte ResistState14 { get; set; }

        public byte ResistState15 { get; set; }

        public byte ResistSkill1 { get; set; }

        public byte ResistSkill2 { get; set; }

        public byte ResistSkill3 { get; set; }

        public byte ResistSkill4 { get; set; }

        public byte ResistSkill5 { get; set; }

        public byte ResistSkill6 { get; set; }

        public int NormalTime { get; set; }

        public byte NormalStep { get; set; }

        public int ChaseTime { get; set; }

        public byte ChaseStep { get; set; }

        public byte ChaseRange { get; set; }

        public short AttackType1 { get; set; }

        public int AttackTime1 { get; set; }

        public byte Attackrange1 { get; set; }

        public short Attack1 { get; set; }

        public short Attackplus1 { get; set; }

        public byte Attackattrib1 { get; set; }

        public byte Attackspecial1 { get; set; }

        public byte Attackok1 { get; set; }

        public short Attacktype2 { get; set; }

        public int Attacktime2 { get; set; }

        public byte Attackrange2 { get; set; }

        public short Attack2 { get; set; }

        public short Attackplus2 { get; set; }

        public byte Attackattrib2 { get; set; }

        public byte Attackspecial2 { get; set; }

        public byte Attackok2 { get; set; }

        public short Attacktype3 { get; set; }

        public int Attacktime3 { get; set; }

        public byte Attackrange3 { get; set; }

        public short Attack3 { get; set; }

        public short Attackplus3 { get; set; }

        public byte Attackattrib3 { get; set; }

        public byte Attackspecial3 { get; set; }

        public byte Attackok3 { get; set; }
    }
}
