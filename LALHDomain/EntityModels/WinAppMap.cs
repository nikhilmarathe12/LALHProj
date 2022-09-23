using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LALHDomain.EntityModels
{
    public class WinAppMap
    {
        [Key]
        public int Id { get; set; }
        public string RecID { get; set; }
        public string WinUser { get; set; }
        public string AppUser { get; set; }
    }
}
