using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
        }
        public override void Operation()
        {
            base.Operation();
        }

        public void Add()
        {
            Console.WriteLine("这是我的扩展功能");
        }
    }
}
