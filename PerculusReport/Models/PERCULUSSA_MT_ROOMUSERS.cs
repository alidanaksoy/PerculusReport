//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerculusReport.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERCULUSSA_MT_ROOMUSERS
    {
        public int ROOMUSERID { get; set; }
        public Nullable<int> ROOMID { get; set; }
        public Nullable<int> USERID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string ATTENDCODE { get; set; }
        public string EMAILADDRESS { get; set; }
        public string USERTYPE { get; set; }
        public Nullable<int> ISBANNED { get; set; }
    
        public virtual PERCULUSSA_ST_ROOMS PERCULUSSA_ST_ROOMS { get; set; }
        public virtual PERCULUSSA_ST_USERS PERCULUSSA_ST_USERS { get; set; }
    }
}
