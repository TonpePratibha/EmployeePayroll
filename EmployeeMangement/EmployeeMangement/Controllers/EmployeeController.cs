using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Model;
using ServiceLayer;

namespace EmployeeMangement.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // Get all employees
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }

        // Get an employee by ID
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null) return NotFound();
            return Ok(employee);
        }

        // Add a new employee
        [HttpPost]
        public IActionResult AddEmployee([FromBody] EmployeeModel employeeModel)
        {
            if (employeeModel == null)
                return BadRequest();

            var addedEmployee = _employeeService.AddEmployee(employeeModel);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = addedEmployee.Name }, addedEmployee);
        }

        // Update an existing employee
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] EmployeeModel employeeModel)
        {
            var updatedEmployee = _employeeService.UpdateEmployee(id, employeeModel);
            if (updatedEmployee == null)
                return NotFound();

            return Ok(updatedEmployee);
        }

        // Delete an employee
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var success = _employeeService.DeleteEmployee(id);
            if (!success)
                return NotFound();

            return NoContent();
        }
    }
}
