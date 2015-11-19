using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PerculusReport.Models.Perculus
{
    [Table("PERCULUSSA_HT_LOGINLOG")]
    public class LoginLog
    {
        [Key]
        public int LOGID { get; set; }

        [Required]
        [StringLength(50)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string IPADDRESS { get; set; }

        public int STATUS { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LOGDATE { get; set; }
    }
}