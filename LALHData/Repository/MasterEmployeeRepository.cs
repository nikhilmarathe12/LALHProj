using LALHData.Context;
using LALHDomain.EntityModels;
using LALHDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LALHData.Repository
{
    public class MasterEmployeeRepository : IMasterEmployeeRepository
    {
        private LALetterHeadDBcontext _LALHDBContext;

        public MasterEmployeeRepository(LALetterHeadDBcontext LALHDBcontext)
        {
            _LALHDBContext = LALHDBcontext;
        }
        public IEnumerable<MasterEmployee> GetMasterEmployees()
        {
            return _LALHDBContext.MasterEmployee;
        }
    }
}
