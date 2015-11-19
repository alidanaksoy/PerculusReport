using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PerculusReport.Models.Perculus
{
    [Table("PERCULUS_EXT_ACTIVESESSIONS")]
    public partial class ActiveSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROOMUSERID { get; set; }

        [Required]
        [StringLength(15)]
        public string USERIP { get; set; }

        [Required]
        [StringLength(15)]
        public string SERVERIP { get; set; }

        public DateTime LOGDATE { get; set; }
    }
}