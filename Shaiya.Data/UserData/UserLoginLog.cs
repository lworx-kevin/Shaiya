namespace Shaiya.Data.UserData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLoginLog")]
    public partial class UserLoginLog
    {
        [Key]
        [Column(Order = 0)]
        public int RowID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SessionID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserUID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string UserIP { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime LoginTime { get; set; }

        public DateTime? LogoutTime { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ErrType { get; set; }

        [StringLength(300)]
        public string ErrMsg { get; set; }

        public int? PCBangRowID { get; set; }
    }
}
