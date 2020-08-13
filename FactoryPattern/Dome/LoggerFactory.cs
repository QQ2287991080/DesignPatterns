using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dome
{
   
    public abstract class LoggerFactory
    {
        /// <summary>
        /// 实现记录日志
        /// </summary>
        public void WriteLog()
        {
            var logger = this.CreateLogger();
            logger.WriteLog();
        }
        public abstract ILogger CreateLogger();
    }
}
