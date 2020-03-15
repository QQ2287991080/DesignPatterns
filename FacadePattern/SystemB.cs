using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class SystemB : ISystemB
    {
        public void MethodB()
        {
            Console.WriteLine("子系统B");
        }
    }
}
