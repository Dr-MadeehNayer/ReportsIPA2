//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportsIPA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public string CourseDescription { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<byte> Level { get; set; }
        public bool IsCourseActive { get; set; }
        public Nullable<byte> Rating { get; set; }
        public Nullable<int> Level2 { get; set; }
    }
}