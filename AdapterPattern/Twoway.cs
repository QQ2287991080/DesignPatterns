using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 双向适配器
    /// </summary>
    public class Twoway : Adaptee, ITarget
    {
        /// <summary>
        /// 同时维持目标类和适配者类的引用
        /// </summary>

        private readonly Adaptee _Adaptee;
        private readonly ITarget _Target;

        public Twoway(Adaptee adaptee)
        {
            _Adaptee = adaptee;
        }
        public Twoway(ITarget target)
        {
            _Target = target;
        }
        public void Request()
        {
            _Adaptee.SpecificRequest();
        }
        public new void SpecificRequest()
        {
            _Target.Request();
        }
    }
}
