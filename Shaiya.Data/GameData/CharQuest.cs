namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CharQuest
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short QuestID { get; set; }

        public short Delay { get; set; }

        public byte Count1 { get; set; }

        public byte Count2 { get; set; }

        public byte Count3 { get; set; }

        public byte Success { get; set; }

        public byte Finish { get; set; }

        public bool Del { get; set; }
    }
}
