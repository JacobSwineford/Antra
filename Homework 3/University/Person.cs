using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.University
{
    public abstract class Person
    {

        private List<string> addresses { get; }
        private int age { get; set; }
        protected decimal baseSalary { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }


        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            addresses = new List<string>();
        }

        public void addAddress(string address)
        {
            addresses.Add(address);
        }

        // very much prefer more details on this
        public abstract decimal salaryFromBase();

        public List<string> getAddresses() { return addresses; }
        public int getAge() { return age; }
        public decimal getBaseSalary() { return baseSalary; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public void setAge(int age) { this.age = age; }
        public void setBaseSalary(decimal salary) { baseSalary = salary; }
        public void setFirstname(string first) { firstName = first; }
        public void setLastName(string last) { lastName = last; }

    }
}
