using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.University
{
    public class Instructor : Person
    {
        private Department department { get; set; }

        public Instructor(string firstName, string lastName, Department department) : base(firstName, lastName)
        {
            this.department = department;
        }

        public override decimal salaryFromBase()
        {
            return baseSalary + 1; // 1 is the bonus
        }

        public Department GetDepartment() { return department; }
        public void setDepartment(Department dep) { department = dep; }

    }
}
