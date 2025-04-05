using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public interface IemployeeRepository
    {
        List<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployeeById(int id);
        EmployeeModel AddEmployee(EmployeeModel employeeModel);
        EmployeeModel UpdateEmployee(int id, EmployeeModel employeeModel);
        bool DeleteEmployee(int id);
    }
}
