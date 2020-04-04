using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    /// <summary>
    /// 对象结构
    /// </summary>
   public class EmployeeList
    {
        private List<Employee> employees = new List<Employee>();

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        public void Accept(Department department)
        {
            foreach (var item in employees)
            {
                item.Accept(department);
            }
        }
    }
}
