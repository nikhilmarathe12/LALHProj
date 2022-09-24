using LHLAApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LHLAApplication.Interfaces
{
    public interface IEmployeeService
    {
       public VMEmployee GetMasterEmployees();
    }
}
