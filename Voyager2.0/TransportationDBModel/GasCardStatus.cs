//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportationDBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class GasCardStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GasCardStatus()
        {
            this.GasCards = new HashSet<GasCard>();
        }
    
        public int StatusId { get; set; }
        public string StatusCode { get; set; }
        public string StatusName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GasCard> GasCards { get; set; }
    }
}