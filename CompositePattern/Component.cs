using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    /// <summary>
    /// 抽象构建
    /// </summary>
    public interface Component
    {

        void Add(Component c);
        void Remove(Component c);
        Component Get(int i);
        void Operation();
    }
}
