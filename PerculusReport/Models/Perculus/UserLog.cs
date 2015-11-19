using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PerculusReport.Models.Perculus
{
    public class UserLog
    {
        public UserLog()
        {
            this.Logs = new List<Log>();
        }
        [Key]
        public int? ROOMUSERID { get; set; }
        public int? ROOMID { get; set; }
        public int? USERID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string ATTENDCODE { get; set; }
        public string EMAILADDRESS { get; set; }
        public string USERTYPE { get; set; }
        public DateTime? FIRSTATTEND { get; set; }
        public DateTime? LASTATTEND { get; set; }
        public int? LATTENDCOUNT { get; set; }
        public double? LATTENDDURATION { get; set; }

        public int? TATTENDCOUNT { get; set; }
        public double? TATTENDDURATION { get; set; }

        public List<Log> Logs { get; set; }
    }
}