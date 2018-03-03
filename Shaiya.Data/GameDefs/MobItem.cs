namespace Shaiya.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MobItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MobID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte ItemOrder { get; set; }

        public short Grade { get; set; }

        public int DropRate { get; set; }
    }
}
