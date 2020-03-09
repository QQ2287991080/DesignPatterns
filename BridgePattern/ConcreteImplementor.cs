using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
   public class ConcreteImplementor:Implementor
    {
        
        public void OperationImp()
        {
            //具体业务实现
            Console.WriteLine("hello");
        }
    }
}
