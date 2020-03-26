using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
   public interface Mediator
    {
        void ComponetCharged(Compoent c);
    }
}
