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
    
    public partial class PERCULUSSA_HT_USERRIGHTS_COMPANY
    {
        public string ACTION { get; set; }
        public string PERMISSION { get; set; }
        public int COMPANYID { get; set; }
        public System.DateTime DATEMODIFIED { get; set; }
    
        public virtual PERCULUSSA_ST_COMPANIES PERCULUSSA_ST_COMPANIES { get; set; }
    }
}
