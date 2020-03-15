using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 子系统A 
    /// </summary>
    public class SystemA: ISystemA
    {
        public void MethodA()
        {
            Console.WriteLine("子系统A");
        }
    }
}
