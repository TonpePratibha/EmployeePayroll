using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DBContext;
using RepositoryLayer.Entity;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class EmployeeRepository:IemployeeRepository

    {
        public readonly ApplicationDBcontext _context;

        public EmployeeRepository(ApplicationDBcontext context) { 
        this._context = context ?? throw new ArgumentNullException(nameof(context));
        }
        // Mapping Employee entity to EmployeeModel (DTO)
        private EmployeeModel MapToModel(Employee employee)
        {
            return new EmployeeModel
            {
                Name = employee.Name,
                image = employee.image,
                Gender = employee.Gender,
                Department = employee.Department,
                Salary = employee.Salary,
                StartDate = employee.StartDate,
                Notes = employee.Notes
            };
        }

        // Mapping EmployeeModel (DTO) to Employee entity
        private Employee MapToEntity(EmployeeModel employeeModel)
        {
            return new Employee
            {
                Name = employeeModel.Name,
                image = employeeModel.image,
                Gender = employeeModel.Gender,
                Department = employeeModel.Department,
                Salary = employeeModel.Salary,
                StartDate = employeeModel.StartDate,
                Notes = employeeModel.Notes
            };
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            var employees = _context.Employees.ToList();
            return employees.Select(e => MapToModel(e)).ToList();
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) return null;
            return MapToModel(employee);
        }

        public EmployeeModel AddEmployee(EmployeeModel employeeModel)
        {
            var employeeEntity = MapToEntity(employeeModel);
            _context.Employees.Add(employeeEntity);
            _context.SaveChanges();
            return MapToModel(employeeEntity);
        }

        public EmployeeModel UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) return null;

            employee.Name = employeeModel.Name;
            employee.image = employeeModel.image;
            employee.Gender = employeeModel.Gender;
            employee.Department = employeeModel.Department;
            employee.Salary = employeeModel.Salary;
            employee.StartDate = employeeModel.StartDate;
            employee.Notes = employeeModel.Notes;

            _context.SaveChanges();
            return MapToModel(employee);
        }

        public bool DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) return false;

            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return true;
        }

    }
}
