using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class EmployeeManager
    {
        public List<Employee> Employees;
        public EmployeeManager()
        {
            Employees = new List<Employee>();
        }


        public void AddEmployee(Employee emp)
        {
               Employees.Add(emp);
        }
        public void UpdateEmployee(int id, string name, string desc, JobType type, int salary)
        {
            //implement
        }

        public List<Employee> SearchBy(string searchBy, string value)
        {
            return searchBy.ToLower() switch
            {
                "id" => Employees.Where(e => e.Id.ToString() == value).ToList(),
                "name" => Employees.Where(e => e.Name.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList(),
                "salary" => Employees.Where(e => e.Salary.ToString() == value).ToList(),
                _ => new List<Employee>()
            };
        }

        public List<Employee> FilterByTitle(JobType title)
        {
            //implement
        }

        public List<Employee> GetSortedList(string sortBy)
        {
            return sortBy.ToLower() switch
            {
                "name" => Employees.OrderBy(e => e.Name).ToList(),
                "salary" => Employees.OrderByDescending(e => e.Salary).ToList(),
                _ => Employees.ToList()
            };

        }
    }
}
