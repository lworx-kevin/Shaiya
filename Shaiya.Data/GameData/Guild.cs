namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Guild
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GuildID { get; set; }

        [Required]
        [StringLength(30)]
        public string GuildName { get; set; }

        [Required]
        [StringLength(18)]
        public string MasterUserID { get; set; }

        public int MasterCharID { get; set; }

        [Required]
        [StringLength(30)]
        public string MasterName { get; set; }

        public byte Country { get; set; }

        public short TotalCount { get; set; }

        public int GuildPoint { get; set; }

        public byte Del { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? DeleteDate { get; set; }
    }
}
