using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PerculusReport.Models.Perculus
{
    [Table("PERCULUSSA_ST_ROOMS")]
    public partial class Room
    {
        public Room()
        {
            Users = new HashSet<RoomUser>();
            Logs = new HashSet<Log>();
        }

        [Key]
        public int ROOMID { get; set; }

        [StringLength(250)]
        public string SESSIONNAME { get; set; }

        public DateTime? ADDDATE { get; set; }

        public DateTime? BEGINDATE { get; set; }

        public int? DURATION { get; set; }

        [StringLength(50)]
        public string LANGUAGEFILE { get; set; }

        public int? SOUND_RATE { get; set; }

        public int? VIDEO_QUALITY { get; set; }

        public int? VIDEO_BANDWIDTH { get; set; }

        [StringLength(250)]
        public string MEDIASERVER_IP { get; set; }

        public int? REQUIRESLOGIN { get; set; }

        [StringLength(4000)]
        public string PASSKEY { get; set; }

        public int? SEND_PASSKEY { get; set; }

        public int? COMPANYID { get; set; }

        [StringLength(250)]
        public string CATEGORY { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION { get; set; }

        public int? SEND_ICS { get; set; }

        public int? INREPLAYMODE { get; set; }

        public long? REPLAYSIZE { get; set; }

        [StringLength(10)]
        public string COLORCODE { get; set; }

        public int FORMENROLL_ALLOW { get; set; }

        public int? FORMENROLL_TYPE { get; set; }

        public int? FORMENROLL_CAPACITY { get; set; }

        [StringLength(250)]
        public string FLASHFILE { get; set; }

        [StringLength(50)]
        public string ROOMGUID { get; set; }

        public int? ROOMOPTIONS { get; set; }

        public int? STREAMCOUNT { get; set; }

        public bool STARTACTIVE { get; set; }

        [Required]
        [StringLength(50)]
        public string USERRIGHTSCHEMA { get; set; }

        [StringLength(250)]
        public string PERMITTEDSYSTEMLAYOUTS { get; set; }

        public int DEFAULTLAYOUTID { get; set; }

        public DateTime? DATEMODIFIED { get; set; }

        public int? USERADDED { get; set; }

        public int? USERMODIFIED { get; set; }

        public bool? AUTOPACKENABLED { get; set; }

        [ForeignKey("ROOMID")]
        public virtual ICollection<RoomUser> Users { get; set; }

        [ForeignKey("ROOMID")]
        public virtual ICollection<Log> Logs { get; set; }
    }
}