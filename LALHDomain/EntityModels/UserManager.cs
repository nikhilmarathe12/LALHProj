using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LALHDomain.EntityModels
{
    public class UserManager
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("UserID")]
        public string UserID { get; set; }

        [DisplayName("UserCode")]
        public string UserCode { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "Required Username")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Username Must be Minimum 2 Charaters")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [Required(ErrorMessage = "Required Password")]
        [MaxLength(4000, ErrorMessage = "Password cannot be Greater than 30 Charaters")]
        [StringLength(4000, MinimumLength = 7, ErrorMessage = "Password Must be Minimum 7 Charaters")]
        public string Password { get; set; }

        [DisplayName("EmpID")]
        public string EmpID { get; set; }

        [DisplayName("DefaultDiv")]
        public string DefaultDiv { get; set; }

        [DisplayName("isActive")]
        public bool isActive { get; set; }

        [DisplayName("AAccess")]
        public bool AAccess { get; set; }

        [DisplayName("isFullRights")]
        public bool isFullRights { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
