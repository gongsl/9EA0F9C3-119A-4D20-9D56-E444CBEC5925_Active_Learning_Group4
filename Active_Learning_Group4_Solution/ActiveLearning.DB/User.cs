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
    
    public partial class User
    {
        public int Sid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public Nullable<System.DateTime> UpdateDT { get; set; }
        public Nullable<System.DateTime> DeleteDT { get; set; }
        public string Role { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual Student Student { get; set; }
    }
}
