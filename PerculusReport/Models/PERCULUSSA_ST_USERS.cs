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
    
    public partial class PERCULUSSA_ST_USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERCULUSSA_ST_USERS()
        {
            this.PERCULUSSA_MT_ROOMUSERS = new HashSet<PERCULUSSA_MT_ROOMUSERS>();
        }
    
        public int USERID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string MODE { get; set; }
        public string EMAILADDRESS { get; set; }
        public Nullable<System.DateTime> ADDDATE { get; set; }
        public Nullable<int> COMPANYID { get; set; }
        public string USERGROUP { get; set; }
        public Nullable<System.DateTime> EXPIRES { get; set; }
        public Nullable<bool> LOGINALLOWED { get; set; }
        public string INTG_EXTRA_STRING1 { get; set; }
        public string INTG_EXTRA_STRING2 { get; set; }
        public Nullable<bool> ISACTIVE { get; set; }
        public string AD_GUID { get; set; }
        public string AD_SID { get; set; }
        public string AD_SAMACCOUNTNAME { get; set; }
        public string AD_DOMAIN { get; set; }
        public string CULTURE { get; set; }
        public Nullable<System.DateTime> DATEADDED { get; set; }
        public Nullable<System.DateTime> DATEMODIFIED { get; set; }
        public Nullable<int> USERADDED { get; set; }
        public Nullable<int> USERMODIFIED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERCULUSSA_MT_ROOMUSERS> PERCULUSSA_MT_ROOMUSERS { get; set; }
    }
}
