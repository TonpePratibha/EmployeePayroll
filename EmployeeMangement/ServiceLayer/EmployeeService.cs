using RepositoryLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IemployeeRepository _employeeRepository;

        public EmployeeService(IemployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        public EmployeeModel AddEmployee(EmployeeModel employeeModel)
        {
            return _employeeRepository.AddEmployee(employeeModel);
        }

        public EmployeeModel UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            return _employeeRepository.UpdateEmployee(id, employeeModel);
        }

        public bool DeleteEmployee(int id)
        {
            return _employeeRepository.DeleteEmployee(id);
        }
    

}
}
