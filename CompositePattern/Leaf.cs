using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    /// <summary>
    /// 叶子构件
    /// </summary>
    public class Leaf : Component
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
            Console.WriteLine("执行业务逻辑LOL");
        }

        public void Remove(Component c)
        {
            Console.WriteLine("不支持该方法");
            return;
        }
    }
}
