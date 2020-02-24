using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   public class Apple:IFruits
    {
        public void AppleMethod()
        {
            Console.WriteLine("这是苹果");
        }

        public void CreateFruits()
        {
            Console.WriteLine("这是水果");
        }
    }
}
