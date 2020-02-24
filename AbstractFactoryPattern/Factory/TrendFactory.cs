using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Specific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    public class TrendFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            Console.WriteLine("创建潮流风格按钮");
            return new TrendButton();
        }

        public ICheckBox CreateCheckBox()
        {
            Console.WriteLine("创建潮流风格复选框");
            return new TrendCheckBox();
        }
    }
}
