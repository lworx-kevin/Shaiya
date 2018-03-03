namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SlotList")]
    public partial class SlotList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotNum { get; set; }
    }
}
