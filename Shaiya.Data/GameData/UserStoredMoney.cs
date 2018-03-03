namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserStoredMoney")]
    public partial class UserStoredMoney
    {
        [Key]
        [Column(Order = 0)]
        public byte ServerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        public long Money { get; set; }

        public DateTime LastAccessTime { get; set; }

        public bool Del { get; set; }
    }
}
