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
    
    public partial class MovieShowtime
    {
        public int MovieShowtimeId { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public Nullable<int> TicketId { get; set; }
        public int MovieId { get; set; }
        public int TheatreId { get; set; }
    
        public virtual Ticket Ticket { get; set; }
        public virtual Theatre Theatre { get; set; }
        public virtual TimeSlot TimeSlot { get; set; }
    }
}
