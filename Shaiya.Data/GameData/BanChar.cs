namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BanChar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BanID { get; set; }

        [Required]
        [StringLength(30)]
        public string BanName { get; set; }

        [StringLength(50)]
        public string Memo { get; set; }

        public DateTime? BanDate { get; set; }
    }
}
