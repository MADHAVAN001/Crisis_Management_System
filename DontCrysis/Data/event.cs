//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DontCrysis.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class @event
    {
        public int idevent { get; set; }
        public string title { get; set; }
        public int idperson { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public int severity { get; set; }
        public System.DateTime date { get; set; }
        public string annotations { get; set; }
        public int idreport { get; set; }
    
        public virtual person person { get; set; }
        public virtual report report { get; set; }
    }
}
