using LHLAApplication.ViewModels;
using System.Collections.Generic;

namespace LHLAApplication.Services
{
    public interface IEmployeeService
    {
        IEnumerable<VMEmployee> GetMasterEmployees();
    }
}
