using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVCW5._BLL.Models
{
    public class EmployeeBLLModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public bool IsRetired { get; set; }       
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }

        public double SalarySuper
        {
            get { return Salary % 9.5; }
        }
    }
}
