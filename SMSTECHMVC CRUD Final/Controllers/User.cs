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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.ExpenseAmounts = new HashSet<ExpenseAmount>();
        }
    
        public int ID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> RankID { get; set; }
        public Nullable<int> NationalityID { get; set; }
        public Nullable<int> EducationID { get; set; }
        public Nullable<int> ExperienceID { get; set; }
        public Nullable<int> ReligionID { get; set; }
        public Nullable<System.DateTime> AppointmentDate { get; set; }
        public Nullable<System.DateTime> TerminationDate { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpenseAmount> ExpenseAmounts { get; set; }
    }
}