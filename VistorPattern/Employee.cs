using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    /// <summary>
    /// 抽象员工类
    /// </summary>
    public interface Employee
    {
        void Accept(Department department);
    }
    /// <summary>
    /// 全职员工
    /// </summary>
    public class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(string name,double wage,int time)
        {
            this.Name = name;
            this.Wage = wage;
            this.Time = time;
        }
        private int time;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        private double wage;

        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Accept(Department department)
        {
            department.Visit(this);
        }

        
    }
    /// <summary>
    /// 兼职员工
    /// </summary>
    public class PartTimeEmployee:Employee
    {
        public PartTimeEmployee(string name, double wage, int time)
        {
            this.Name = name;
            this.Wage = wage;
            this.Time = time;
        }
        private int time;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        private double wage;

        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Accept(Department department)
        {
            department.Visit(this);
        }
    }
}
