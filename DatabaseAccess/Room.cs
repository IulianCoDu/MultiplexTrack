//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public int RoomId { get; set; }
        public Nullable<int> RoomNumber { get; set; }
        public Nullable<int> TheatreId { get; set; }
    
        public virtual Theatre Theatre { get; set; }
        public virtual Seats Seats { get; set; }
    }
}
