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
    
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public string ScreenNumber { get; set; }
        public Nullable<int> SeatNumber { get; set; }
        public Nullable<System.DateTime> StartHour { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> MovieShowtimeId { get; set; }
    
        public virtual MovieShowtime MovieShowtime { get; set; }
        public virtual User User { get; set; }
    }
}
