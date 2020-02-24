using AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Specific
{
    public class TrendCheckBox : ICheckBox
    {
        public void Display()
        {
            Console.WriteLine("显示潮流复选框");
        }
    }
}
