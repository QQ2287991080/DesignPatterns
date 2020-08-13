using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dome
{
    /// <summary>
    /// 修改 日志记录
    /// </summary>
    public class Update : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("修改日志");
        }
    }
}
