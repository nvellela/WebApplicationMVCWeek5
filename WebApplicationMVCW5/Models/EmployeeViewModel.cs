using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVCW5.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(50, ErrorMessage = "SomeMessage abt 50 length")]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Required(ErrorMessage = "Required field")]
        [DisplayName("Annual Salary")]
        //[RegularExpression("([1-9][0-9]*)")] for 1-inf
        public int Salary { get; set; }

        public bool IsRetired { get; set; }
        public string SalarySuper { get; set; }
        public string SalaryColor { get; set; }
    }
}

