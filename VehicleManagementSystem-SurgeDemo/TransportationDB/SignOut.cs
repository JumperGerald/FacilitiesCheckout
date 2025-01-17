//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportationDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SignOut
    {
        public int SignOutId { get; set; }
        public int UserId { get; set; }
        public string Destination { get; set; }
        public int VehicleId { get; set; }
        public int KeyId { get; set; }
        public int GasCardId { get; set; }
        public Nullable<System.DateTime> CheckOutTime { get; set; }
        public Nullable<System.DateTime> CheckInTime { get; set; }
        public Nullable<System.DateTime> ActivityTime { get; set; }
    
        public virtual GasCard GasCard { get; set; }
        public virtual Key Key { get; set; }
        public virtual User User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
