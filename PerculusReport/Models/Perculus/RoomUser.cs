using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PerculusReport.Models.Perculus
{
    [Table("PERCULUSSA_MT_ROOMUSERS")]
    public partial class RoomUser
    {
        [Key]
        public int ROOMUSERID { get; set; }

        public int? ROOMID { get; set; }

        public int? USERID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string SURNAME { get; set; }

        [StringLength(100)]
        public string ATTENDCODE { get; set; }

        [StringLength(250)]
        public string EMAILADDRESS { get; set; }

        [StringLength(1)]
        public string USERTYPE { get; set; }

        public int? ISBANNED { get; set; }

        public virtual Room PERCULUSSA_ST_ROOMS { get; set; }

        public virtual PUser PERCULUSSA_ST_USERS { get; set; }
    }
}