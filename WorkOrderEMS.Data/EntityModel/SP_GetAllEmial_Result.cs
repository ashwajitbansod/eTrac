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
    
    public partial class SP_GetAllEmial_Result
    {
        public long EmailLogId { get; set; }
        public Nullable<long> SentBy { get; set; }
        public string sent_By_User { get; set; }
        public string SentTo { get; set; }
        public string SentEmail { get; set; }
        public string Subject { get; set; }
        public Nullable<long> LocationId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool isForgot { get; set; }
    }
}