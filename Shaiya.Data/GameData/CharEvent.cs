namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CharEvent
    {
        [Key]
        [Column(Order = 0)]
        public int RowID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte Event1 { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte Event2 { get; set; }

        public byte? Event3 { get; set; }

        public byte? Event4 { get; set; }

        public byte? Event5 { get; set; }

        public byte? Event6 { get; set; }

        public byte? Event7 { get; set; }

        public byte? Event8 { get; set; }

        public byte? Event9 { get; set; }

        public byte? Event10 { get; set; }
    }
}
