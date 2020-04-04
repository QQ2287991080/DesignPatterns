using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    /// <summary>
    /// 抽象部门类
    /// </summary>
    public abstract class Department
    {
        public abstract void Visit(FullTimeEmployee employee);
        public abstract void Visit(PartTimeEmployee employee);
    }


    public class FA : Department
    {
        public override void Visit(FullTimeEmployee employee)
        {
            int time = employee.Time;
            double wage = employee.Wage;
            if (wage>40)
            {
                wage = wage + (time - 40) * 100;
            }
            else
            {
                wage = wage - (40 - time) * 80;
            }
            Console.WriteLine($"正式员工{employee.Name}工资：{wage*time}");
        }

        public override void Visit(PartTimeEmployee employee)
        {
            Console.WriteLine($"零时工{employee.Name},工资：{employee.Wage*employee.Time}");
        }
    }

    public class HR : Department
    {
        public override void Visit(FullTimeEmployee employee)
        {
            Console.WriteLine($"{employee.Name}工作时间为：{employee.Time}");
            if (employee.Time>40)
            {
                Console.WriteLine($"{employee.Name}加班时间为：{employee.Time-40}");
            }
            else
            {
                Console.WriteLine($"{employee.Name}请假时间为：{40-employee.Time}");
            }
        }

        public override void Visit(PartTimeEmployee employee)
        {
            Console.WriteLine($"{employee.Name}工作时间为：{employee.Time}");
        }
    }
}
