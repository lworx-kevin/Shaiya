namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FriendChar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FriendID { get; set; }

        [Required]
        [StringLength(30)]
        public string FriendName { get; set; }

        public byte Family { get; set; }

        public byte Grow { get; set; }

        public byte Job { get; set; }

        [StringLength(50)]
        public string Memo { get; set; }

        public byte? Refuse { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? RefuseDate { get; set; }
    }
}
