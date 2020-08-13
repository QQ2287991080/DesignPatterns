using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dome
{
    /// <summary>
    /// 查询
    /// </summary>
    public class SelectFactory : LoggerFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override ILogger CreateLogger()
        {
            return new Select();
        }
    }
}
