using LALHDomain.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LALHDomain.Interfaces
{
    public interface IMasterEmployeeRepository
    {
       public IEnumerable<MasterEmployee> GetMasterEmployees();
    }
}
