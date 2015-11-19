using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PerculusReport.Models.Perculus
{
    [Table("PERCULUSSA_ST_REPORTS")]
    public partial class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REPORTID { get; set; }

        [StringLength(500)]
        public string REPORTNAME { get; set; }

        [StringLength(50)]
        public string SP_NAME { get; set; }

        [StringLength(4000)]
        public string PARAMETERS { get; set; }

        [Column(TypeName = "ntext")]
        public string DESCRIPTION { get; set; }

        public int RANKING { get; set; }

        public bool SHOWREPORT { get; set; }

        public DateTime DATEADDED { get; set; }
    }
}