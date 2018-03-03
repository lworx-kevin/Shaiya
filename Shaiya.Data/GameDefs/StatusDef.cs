namespace Shaiya.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StatusDef
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Level { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte Job { get; set; }

        public short HP { get; set; }

        public short SP { get; set; }

        public short MP { get; set; }
    }
}
