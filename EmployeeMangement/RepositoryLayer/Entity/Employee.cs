using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Entity
{
   public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        public string Name { get;set; }

        public string image { get; set; }
        [Required(ErrorMessage ="Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Department is required")]
        public string Department { get; set; }
        [Required(ErrorMessage ="Salary is required")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "date is required")]
        public DateTime StartDate { get; set; }

        public string Notes { get; set; }


    }
}
