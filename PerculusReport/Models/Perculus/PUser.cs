using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PerculusReport.Models.Perculus
{
    [Table("PERCULUSSA_ST_USERS")]
    public partial class PUser
    {
        public PUser()
        {
            PERCULUSSA_MT_ROOMUSERS = new HashSet<RoomUser>();
        }

        [Key]
        public int USERID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string SURNAME { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        [StringLength(250)]
        public string PASSWORD { get; set; }

        [StringLength(1)]
        public string MODE { get; set; }

        [StringLength(250)]
        public string EMAILADDRESS { get; set; }

        public DateTime? ADDDATE { get; set; }

        public int? COMPANYID { get; set; }

        [StringLength(250)]
        public string USERGROUP { get; set; }

        public DateTime? EXPIRES { get; set; }

        public bool? LOGINALLOWED { get; set; }

        [StringLength(4000)]
        public string INTG_EXTRA_STRING1 { get; set; }

        [StringLength(4000)]
        public string INTG_EXTRA_STRING2 { get; set; }

        public bool? ISACTIVE { get; set; }

        [StringLength(50)]
        public string AD_GUID { get; set; }

        [StringLength(200)]
        public string AD_SID { get; set; }

        [StringLength(100)]
        public string AD_SAMACCOUNTNAME { get; set; }

        [StringLength(50)]
        public string AD_DOMAIN { get; set; }

        [StringLength(10)]
        public string CULTURE { get; set; }

        public DateTime? DATEADDED { get; set; }

        public DateTime? DATEMODIFIED { get; set; }

        public int? USERADDED { get; set; }

        public int? USERMODIFIED { get; set; }

        public virtual ICollection<RoomUser> PERCULUSSA_MT_ROOMUSERS { get; set; }
    }
}