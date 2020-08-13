using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dome
{
    public class UpdateFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new Update();
        }
    }
}
