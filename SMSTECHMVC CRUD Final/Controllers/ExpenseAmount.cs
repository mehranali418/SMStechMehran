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
    
    public partial class ExpenseAmount
    {
        public int ID { get; set; }
        public Nullable<int> ExpenseHeadID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> T_Date { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> SalaryMonthID { get; set; }
        public string Remarks { get; set; }
        public string ExpenseTitle { get; set; }
    
        public virtual User User { get; set; }
    }
}
