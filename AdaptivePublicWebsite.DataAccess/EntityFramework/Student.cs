//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FamtasticPublicWebsite.DataAccess.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int ID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual Course Course { get; set; }
    }
}