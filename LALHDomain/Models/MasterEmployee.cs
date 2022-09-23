using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LALHDomain.Models
{
    public class MasterEmployee
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("RecID")]
        public string RecID { get; set; }

        [DisplayName("EmpCode")]
        public string EmpCode { get; set; }

        [DisplayName("FName")]
        public string FName { get; set; }

        [DisplayName("LName")]
        public string LName { get; set; }

        [DisplayName("AddrLine1")]
        public string AddrLine1 { get; set; }
        [DisplayName("AddrLine2")]
        public string AddrLine2 { get; set; }
        [DisplayName("AddrLine3")]
        public string AddrLine3 { get; set; }

        [DisplayName("AddrLine4")]
        public string AddrLine4 { get; set; }

        [DisplayName("Telephone")]
        public string Telephone { get; set; }

        [DisplayName("Mobile")]
        public string Mobile { get; set; }

        [DisplayName("Fax")]
        public string Fax { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("isEnable")]
        public string isEnable { get; set; }

        [DisplayName("isDeleted")]
        public string isDeleted { get; set; }

        [DisplayName("ReportingHead")]
        public string ReportingHead { get; set; }

        [DisplayName("ReportingHeadEmails")]
        public string ReportingHeadEmails { get; set; }

        [DisplayName("isForLAUser")]
        public string isForLAUser { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
