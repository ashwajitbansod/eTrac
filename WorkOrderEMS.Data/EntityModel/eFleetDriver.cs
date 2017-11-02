//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkOrderEMS.Data.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class eFleetDriver
    {
        public long DriverID { get; set; }
        public Nullable<long> LocationID { get; set; }
        public Nullable<long> EmployeeName { get; set; }
        public string DriverLicenseNo { get; set; }
        public int StateId { get; set; }
        public string CDLType { get; set; }
        public Nullable<System.DateTime> CDLExpiration { get; set; }
        public Nullable<System.DateTime> MedicleCardExpiration { get; set; }
        public Nullable<System.DateTime> MVRExpiration { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<int> IsPasswordChanged { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string DriverImage { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual LocationMaster LocationMaster { get; set; }
        public virtual UserRegistration UserRegistration { get; set; }
    }
}
