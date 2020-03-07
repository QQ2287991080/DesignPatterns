using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   public class Target : ITarget
    {
        public void Request()
        {
            Console.WriteLine("我是目标类");
        }
    }
}
