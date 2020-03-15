using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 抽象装饰类
    /// </summary>
  public  class Decorator:Component
    {
        //典型语法
        private Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }
        public override void Operation()
        {
            _component.Operation();
        }


    }
}
