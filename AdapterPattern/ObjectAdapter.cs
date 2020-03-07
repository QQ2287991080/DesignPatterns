using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 适配器 
    /// </summary>
    public class ObjectAdapter : ITarget
    {
        private readonly Adaptee _Adaptee;
        public ObjectAdapter(Adaptee adaptee)
        {
            _Adaptee = adaptee;
        }
        public void Request()
        {
            _Adaptee.SpecificRequest();
        }
    }
}
