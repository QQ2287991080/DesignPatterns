using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dome
{
    /// <summary>
    /// 查询记录日志，充当具体产品
    /// </summary>
    public class Select : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("记录查询");
        }
    }
}
