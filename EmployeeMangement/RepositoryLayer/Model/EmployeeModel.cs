using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Model
{
    public class EmployeeModel
    {
        public string Name { get; set; }

        public string image { get; set; }
      
        public string Gender { get; set; }

        
        public string Department { get; set; }
      
        public decimal Salary { get; set; }

        
        public DateTime StartDate { get; set; }

        public string Notes { get; set; }
    }
}
