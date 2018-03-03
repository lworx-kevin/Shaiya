namespace Shaiya.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        [Required]
        [StringLength(30)]
        public string ItemName { get; set; }

        public byte Type { get; set; }

        public byte TypeID { get; set; }

        public short Reqlevel { get; set; }

        public byte Country { get; set; }

        public byte Attackfighter { get; set; }

        public byte Defensefighter { get; set; }

        public byte Patrolrogue { get; set; }

        public byte Shootrogue { get; set; }

        public byte Attackmage { get; set; }

        public byte Defensemage { get; set; }

        public byte Grow { get; set; }

        public short ReqStr { get; set; }

        public short ReqDex { get; set; }

        public short ReqRec { get; set; }

        public short ReqInt { get; set; }

        public short ReqWis { get; set; }

        public short Reqluc { get; set; }

        public short ReqVg { get; set; }

        public byte ReqOg { get; set; }

        public byte ReqIg { get; set; }

        public short Range { get; set; }

        public byte AttackTime { get; set; }

        public byte Attrib { get; set; }

        public byte Special { get; set; }

        public byte Slot { get; set; }

        public short Quality { get; set; }

        public short Effect1 { get; set; }

        public short Effect2 { get; set; }

        public short Effect3 { get; set; }

        public short Effect4 { get; set; }

        public short ConstHP { get; set; }

        public short ConstSP { get; set; }

        public short ConstMP { get; set; }

        public short ConstStr { get; set; }

        public short ConstDex { get; set; }

        public short ConstRec { get; set; }

        public short ConstInt { get; set; }

        public short ConstWis { get; set; }

        public short ConstLuc { get; set; }

        public byte Speed { get; set; }

        public byte Exp { get; set; }

        public int Buy { get; set; }

        public int Sell { get; set; }

        public short Grade { get; set; }

        public short Drop { get; set; }

        public byte Server { get; set; }

        public byte Count { get; set; }
    }
}
