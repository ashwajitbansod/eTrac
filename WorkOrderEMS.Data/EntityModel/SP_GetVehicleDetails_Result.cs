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
    
    public partial class SP_GetVehicleDetails_Result
    {
        public long VehicleID { get; set; }
        public long QRCID { get; set; }
        public Nullable<long> VendorUserID { get; set; }
        public string CompanyTaxIdNo { get; set; }
        public string AcknowledgementForm { get; set; }
        public string W9Form { get; set; }
        public Nullable<long> FeeFrequency { get; set; }
        public Nullable<long> IsApprovedByManager { get; set; }
        public string ManagerDenialReason { get; set; }
        public Nullable<long> IsApprovedByClient { get; set; }
        public string ClientDenialReason { get; set; }
        public string SpecialNotes { get; set; }
        public Nullable<System.DateTime> PickUpDateTime { get; set; }
        public string VehicleImage { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleIdentificationNo { get; set; }
        public Nullable<long> VehicleType { get; set; }
        public System.DateTime VehicleRegistratoinExpiry { get; set; }
        public string VehicleRegistratoinProofDoc { get; set; }
        public string VehicleTagNo { get; set; }
        public string CityPermitNo { get; set; }
        public Nullable<System.DateTime> CityPermitExpiryDate { get; set; }
        public Nullable<System.DateTime> PermitDuration { get; set; }
        public string DriverName { get; set; }
        public string LicenseNo { get; set; }
        public Nullable<System.DateTime> LicenseExpiryDate { get; set; }
        public string LicenseProofDoc { get; set; }
        public long PermitType { get; set; }
        public string PermitBillingCode { get; set; }
        public string InsurancePlan { get; set; }
        public string DriverProfilePic { get; set; }
        public string PolicyNo { get; set; }
        public Nullable<System.DateTime> PolicyExpiration { get; set; }
        public string InsuranceProofDoc { get; set; }
        public long UserId { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public string AlternateEmail { get; set; }
        public string SubscriptionEmail { get; set; }
        public long UserType { get; set; }
        public Nullable<long> ProjectID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<long> Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string ProfileImage { get; set; }
        public long VendorID { get; set; }
        public string CompanyName { get; set; }
        public string DBA { get; set; }
        public string ContactName { get; set; }
        public string ManagerPOC { get; set; }
        public string MobilePOC { get; set; }
        public string BusinessNo { get; set; }
        public string IndustryName { get; set; }
        public string CompanyLogo { get; set; }
        public Nullable<long> CompanySize { get; set; }
        public System.DateTime JoinFrom { get; set; }
        public Nullable<long> PermitDetailsType { get; set; }
        public string VehicleCode { get; set; }
        public Nullable<decimal> PermitTypePrice { get; set; }
        public Nullable<long> LocationId { get; set; }
    }
}