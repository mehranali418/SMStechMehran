//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Attendance
    {
        public int ID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<System.DateTime> sDate { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<byte> Type { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> Present { get; set; }
        public Nullable<bool> Absent { get; set; }
        public Nullable<bool> Leave { get; set; }
        public Nullable<bool> Offday { get; set; }
    }
}
