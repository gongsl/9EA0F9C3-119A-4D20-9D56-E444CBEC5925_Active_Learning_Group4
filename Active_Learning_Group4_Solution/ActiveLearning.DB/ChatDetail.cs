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
    
    public partial class ChatDetail
    {
        public int Sid { get; set; }
        public Nullable<int> ChatRecordSid { get; set; }
        public Nullable<int> StuentSid { get; set; }
        public Nullable<int> InstructorSid { get; set; }
        public string Message { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual ChatRecord ChatRecord { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}