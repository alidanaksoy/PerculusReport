using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PerculusReport.Models.Perculus
{
    [Table("PERCULUSSA_ST_LOGS")]
    public partial class Log
    {
        [Key]
        public int LOGID { get; set; }

        public int? USERID { get; set; }

        public int? ROOMID { get; set; }

        public int? ROOMUSERID { get; set; }

        public DateTime? ENTERDATE { get; set; }

        public DateTime? EXITDATE { get; set; }

        [StringLength(50)]
        public string IPADDRESS { get; set; }

        public bool? ISREPLAY { get; set; }

        public virtual Room PERCULUSSA_ST_ROOMS { get; set; }
    }
}