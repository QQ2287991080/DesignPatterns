using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.DefaultAdapterPattern
{
    /// <summary>
    /// 具体业务类
    /// </summary>
    public class ConcreteService : Service
    {
        public override void Face1()
        {
            Console.WriteLine("实现方法1");
        }
    }
}
