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
    
    public partial class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public string Type { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public string Category { get; set; }
        public byte[] Poster { get; set; }
        public string Description { get; set; }
    }
}
