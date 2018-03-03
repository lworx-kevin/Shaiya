namespace Shaiya.Data.UserData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users_BlockLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Status { get; set; }

        public DateTime? BlockEndDate { get; set; }

        [StringLength(18)]
        public string GmID { get; set; }

        public DateTime? InsertDate { get; set; }
    }
}
