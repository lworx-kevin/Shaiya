namespace Shaiya.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Keep
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KeepID { get; set; }

        public byte OwnCountry { get; set; }

        public int ResetTime { get; set; }
    }
}
