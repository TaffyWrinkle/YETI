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
    
    public partial class YM_MissedFileAttachments
    {
        public int ID { get; set; }
        public Nullable<long> fileId { get; set; }
        public string fileName { get; set; }
        public Nullable<long> threadId { get; set; }
        public Nullable<long> groupId { get; set; }
        public string groupName { get; set; }
        public string csvfilename { get; set; }
        public string status { get; set; }
        public Nullable<int> timesTried { get; set; }
        public Nullable<System.DateTime> UploadedAt { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public string ProcessedBy { get; set; }
    }
}