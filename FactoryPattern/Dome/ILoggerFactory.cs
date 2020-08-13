using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dome
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public interface ILoggerFactory
    {
        /// <summary>
        /// 返回实例对象
        /// </summary>
        /// <returns></returns>
        ILogger CreateLogger();
    }
}
