namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CharSkill
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SkillID { get; set; }

        public byte SkillLevel { get; set; }

        public byte Number { get; set; }

        public short Delay { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateTime { get; set; }

        public bool Del { get; set; }
    }
}
