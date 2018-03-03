namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMaxGrow")]
    public partial class UserMaxGrow
    {
        [Key]
        [Column(Order = 0)]
        public byte ServerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        public byte Country { get; set; }

        public byte MaxGrow { get; set; }

        public bool Del { get; set; }
    }
}
