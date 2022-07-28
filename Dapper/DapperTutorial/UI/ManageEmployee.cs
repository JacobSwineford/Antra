using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.UI
{
    public class ManageEmployee
    {

        EmployeeRepository er;

        ManageEmployee()
        {
            er = new EmployeeRepository();
        }

        void AddEmployee(Employee e)
        {
            er.Insert(e);
        }

        void updateEmployee(Employee e)
        {
            er.Update(e);
        }

        void RemoveEmployee(Employee e)
        {
            er.DeleteById(e.Id);
        }

        Employee GetEmployee(int id)
        {
            return er.GetById(id); 
        }

        IEnumerable<Employee> GetAllEmployees()
        {
            return er.GetAll();
        }


    }
}
