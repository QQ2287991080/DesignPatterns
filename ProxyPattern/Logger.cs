using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
  public  class Logger
    {
        public void Log(string userId)
        {
            Console.WriteLine(userId + "用户查询次数+1");
        }
    }
}
