using LALHDomain.Interfaces;
using LHLAApplication.Interfaces;
using LHLAApplication.ViewModels;
using System.Collections.Generic;

namespace LHLAApplication.Services
{
    public class EmployeeService : IEmployeeService
    {

        private IMasterEmployeeRepository _employeeRepository;

        public EmployeeService(IMasterEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public VMEmployee GetMasterEmployees()
        {
            return new VMEmployee()
            {
                MasterEmployees = _employeeRepository.GetMasterEmployees()
            };
        }
    }
}
