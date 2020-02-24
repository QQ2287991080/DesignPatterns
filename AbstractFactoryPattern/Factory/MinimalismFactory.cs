using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Specific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    public class MinimalismFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            Console.WriteLine("创建极简风格按钮");
            return new MinimalismButton();
        }

        public ICheckBox CreateCheckBox()
        {
            Console.WriteLine("创建极简风格复选框");
            return new MinimalismCheckBox();
        }
    }
}
