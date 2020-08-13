using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dome
{
    /// <summary>
    /// 新增
    /// </summary>
    public class InsertFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new Insert();
        }
    }
}
