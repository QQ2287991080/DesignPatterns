using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
  public  class EagerSingleton
    {
        private static EagerSingleton _instance = new EagerSingleton();//初始化

        private EagerSingleton()
        { 
        
        }
         
        public static EagerSingleton GetIntance()
        {
            return _instance;
        }
    }
}
