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
    
    public partial class SP_GetEmailDetailsInfraction_Result
    {
        public string locationName { get; set; }
        public long InfractionId { get; set; }
        public string VendorEmail { get; set; }
        public string vendor_Name { get; set; }
        public long vendoruserId { get; set; }
        public string ManagerEmail { get; set; }
        public string Manager_Name { get; set; }
        public Nullable<long> ManagerUserId { get; set; }
        public string SubmittedEmail { get; set; }
        public string Submitted_Name { get; set; }
        public long SubmittedUserId { get; set; }
        public string ClientEmail { get; set; }
        public string Client_Name { get; set; }
        public Nullable<long> ClientUserId { get; set; }
        public string DriverName { get; set; }
        public string LicenseNo { get; set; }
        public string PermitType { get; set; }
        public string VehicleIdentificationNo { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string InfractionType { get; set; }
        public System.DateTime InfractionSubmittedOn { get; set; }
        public long InfractionLevelDetailId { get; set; }
        public string InfractionLevel { get; set; }
        public string Comment { get; set; }
        public string TimeSpan { get; set; }
        public long LocationId { get; set; }
    }
}