//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YammerLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class YM_ExportDetails
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> IsUploaded { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public string ProcessStage { get; set; }
        public string ProcessedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UploadedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> TimesTried { get; set; }
        public Nullable<long> MessagesCount { get; set; }
        public Nullable<long> FilesCount { get; set; }
        public Nullable<long> PagesCount { get; set; }
        public Nullable<long> GroupsCount { get; set; }
        public Nullable<long> TopicsCount { get; set; }
        public Nullable<long> UsersCount { get; set; }
        public Nullable<bool> IsVerified { get; set; }
    }
}
