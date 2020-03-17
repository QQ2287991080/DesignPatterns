using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Food : Component
    {
        public void Add(Component c)
        {
            Console.WriteLine("不支持该方法");
            return;
        }

        public Component Get(int i)
        {
            Console.WriteLine("不支持该方法");
            return null;
        }

        public void Operation()
        {
            Console.WriteLine("我要吃东西");
        }

        public void Remove(Component c)
        {
            Console.WriteLine("不支持该方法");
            return;
        }
    }
}
