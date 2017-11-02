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
    
    public partial class WeeklyVehicleCheck
    {
        public long WeeklyVehicleCheckID { get; set; }
        public long VehicleID { get; set; }
        public bool IsDamage { get; set; }
        public string DamageToReportImage { get; set; }
        public string DamageToReportRemarks { get; set; }
        public long CurrentMileage { get; set; }
        public bool IsInteriorClean { get; set; }
        public string InteriorCleanRemarks { get; set; }
        public bool IsExteriorClean { get; set; }
        public string ExteriorCleanRemarks { get; set; }
        public long VehicleTransmission { get; set; }
        public long FuelLevel { get; set; }
        public long VehicleTires { get; set; }
        public long VehicleWindows { get; set; }
        public long VehicleBrakes { get; set; }
        public System.DateTime VehicleCheckDate { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual GlobalCode GlobalCode { get; set; }
        public virtual GlobalCode GlobalCode1 { get; set; }
        public virtual GlobalCode GlobalCode2 { get; set; }
        public virtual GlobalCode GlobalCode3 { get; set; }
        public virtual GlobalCode GlobalCode4 { get; set; }
    }
}