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
    
    public partial class person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public person()
        {
            this.@event = new HashSet<@event>();
        }
    
        public int idPerson { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string area { get; set; }
        public string nric { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<@event> @event { get; set; }
    }
}