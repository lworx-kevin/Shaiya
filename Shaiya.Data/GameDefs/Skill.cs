namespace Shaiya.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Skill
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SkillID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte SkillLevel { get; set; }

        [Required]
        [StringLength(30)]
        public string SkillName { get; set; }

        public byte Country { get; set; }

        public byte Attackfighter { get; set; }

        public byte Defensefighter { get; set; }

        public byte Patrolrogue { get; set; }

        public byte Shootrogue { get; set; }

        public byte Attackmage { get; set; }

        public byte Defensemage { get; set; }

        public short PrevSkillID { get; set; }

        public short ReqLevel { get; set; }

        public byte Grow { get; set; }

        public byte SkillPoint { get; set; }

        public byte TypeShow { get; set; }

        public byte TypeAttack { get; set; }

        public byte TypeEffect { get; set; }

        public short TypeDetail { get; set; }

        public byte NeedWeapon1 { get; set; }

        public byte NeedWeapon2 { get; set; }

        public byte NeedWeapon3 { get; set; }

        public byte NeedWeapon4 { get; set; }

        public byte NeedWeapon5 { get; set; }

        public byte NeedWeapon6 { get; set; }

        public byte NeedWeapon7 { get; set; }

        public byte NeedWeapon8 { get; set; }

        public byte NeedWeapon9 { get; set; }

        public byte NeedWeapon10 { get; set; }

        public byte NeedWeapon11 { get; set; }

        public byte NeedWeapon12 { get; set; }

        public byte NeedWeapon13 { get; set; }

        public byte NeedWeapon14 { get; set; }

        public byte NeedWeapon15 { get; set; }

        public byte Shield { get; set; }

        public short SP { get; set; }

        public short MP { get; set; }

        public byte ReadyTime { get; set; }

        public short ResetTime { get; set; }

        public byte AttackRange { get; set; }

        public byte StateType { get; set; }

        public byte AttrType { get; set; }

        public short Disable { get; set; }

        public byte SuccessType { get; set; }

        public byte SuccessValue { get; set; }

        public byte TargetType { get; set; }

        public byte ApplyRange { get; set; }

        public byte MultiAttack { get; set; }

        public short KeepTime { get; set; }

        public byte Weapon1 { get; set; }

        public byte Weapon2 { get; set; }

        public byte Weaponvalue { get; set; }

        public byte Bag { get; set; }

        public short Arrow { get; set; }

        public byte DamageType { get; set; }

        public short DamageHP { get; set; }

        public short DamageSP { get; set; }

        public short DamageMP { get; set; }

        public byte TimeDamageType { get; set; }

        public short TimeDamageHP { get; set; }

        public short TimeDamageSP { get; set; }

        public short TimeDamageMP { get; set; }

        public short AddDamageHP { get; set; }

        public short AddDamageSP { get; set; }

        public short AddDamageMP { get; set; }

        public byte? AbilityType1 { get; set; }

        public short? AbilityValue1 { get; set; }

        public byte? AbilityType2 { get; set; }

        public short? AbilityValue2 { get; set; }

        public byte? AbilityType3 { get; set; }

        public short? AbilityValue3 { get; set; }

        public short HealHP { get; set; }

        public short HealSP { get; set; }

        public short HealMP { get; set; }

        public short TimeHealHP { get; set; }

        public short TimeHealSP { get; set; }

        public short TimeHealMP { get; set; }

        public byte DefenceType { get; set; }

        public byte DefenceValue { get; set; }

        public byte LimitHP { get; set; }

        public byte FixRange { get; set; }

        public short ChangeType { get; set; }

        public short ChangeLevel { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
