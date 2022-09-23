using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LALHDomain.EntityModels
{
    public class WinAppMap
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(15)")]
        public string RecID { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string WinUser { get; set; }

        [Column(TypeName = "VARCHAR(15)")]
        public string AppUser { get; set; }
    }
}
