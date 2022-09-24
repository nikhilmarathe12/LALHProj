using LALHDomain.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LHLAApplication.ViewModels
{
    public class VMEmployee
    {
        public IEnumerable<MasterEmployee> MasterEmployees { get; set; }

    }
}
