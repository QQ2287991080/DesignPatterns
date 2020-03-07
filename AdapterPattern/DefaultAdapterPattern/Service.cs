using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.DefaultAdapterPattern
{
    /// <summary>
    /// 适配器类（核心）
    /// </summary>
    public abstract class Service : IInterface
    {
        public virtual void Face1()
        {
            throw new NotImplementedException();
        }

        public virtual void Face2()
        {
            throw new NotImplementedException();
        }

        public virtual void Face3()
        {
            throw new NotImplementedException();
        }
    }
}
