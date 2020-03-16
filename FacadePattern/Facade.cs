using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 外观类
    /// </summary>
   public class Facade
    {
        private ISystemA SystemA = new SystemA();
        private ISystemB SystemB = new SystemB();
        public void Meathod()
        {
            SystemA.MethodA();
            SystemB.MethodB();
        }

    }
}
