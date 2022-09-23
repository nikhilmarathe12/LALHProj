using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LALHDomain.EntityModels
{
    public class MasterEmployee
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("RecID")]
        [Column(TypeName = "VARCHAR(15)")]
        public string RecID { get; set; }

        [DisplayName("EmpCode")]
        [Column(TypeName = "VARCHAR(10)")]
        public string EmpCode { get; set; }

        [DisplayName("FName")]
        [Column(TypeName = "VARCHAR(50)")]
        public string FName { get; set; }

        [DisplayName("LName")]
        [Column(TypeName = "VARCHAR(50)")]
        public string LName { get; set; }

        [DisplayName("AddrLine1")]
        [Column(TypeName = "VARCHAR(50)")]
        public string AddrLine1 { get; set; }

        [DisplayName("AddrLine2")]
        [Column(TypeName = "VARCHAR(50)")]
        public string AddrLine2 { get; set; }

        [DisplayName("AddrLine3")]
        [Column(TypeName = "VARCHAR(50)")]
        public string AddrLine3 { get; set; }


        [DisplayName("AddrLine4")]
        [Column(TypeName = "VARCHAR(50)")]
        public string AddrLine4 { get; set; }

        [DisplayName("Telephone")]
        [Column(TypeName = "VARCHAR(50)")]
        public string Telephone { get; set; }

        [DisplayName("Mobile")]
        [Column(TypeName = "VARCHAR(50)")]
        public string Mobile { get; set; }

        [DisplayName("Fax")]
        [Column(TypeName = "VARCHAR(50)")]
        public string Fax { get; set; }

        [DisplayName("Email")]
        [Column(TypeName = "VARCHAR(200)")]
        public string Email { get; set; }

        [DisplayName("isEnable")]
        public Boolean isEnable { get; set; }

        [DisplayName("isDeleted")]
        public Boolean isDeleted { get; set; }

        [DisplayName("ReportingHead")]
        [Column(TypeName = "VARCHAR(15)")]
        public string ReportingHead { get; set; }

        [DisplayName("ReportingHeadEmails")]
        [Column(TypeName = "VARCHAR(200)")]
        public string ReportingHeadEmails { get; set; }

        [DisplayName("isForLAUser")]
        [Column(TypeName = "Int")]
        public int isForLAUser { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string CreatedBy { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string ModifiedBy { get; set; }

    }
}
