//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActiveLearning.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Course_Map
    {
        public int Sid { get; set; }
        public Nullable<int> StudentSid { get; set; }
        public Nullable<int> CourseSid { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}