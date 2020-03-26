using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 抽象组件类
    /// </summary>
   public abstract class Compoent
    {
        protected Mediator Mediator;

        public void SetMediator(Mediator mediator)
        {
            this.Mediator = mediator;
        }
        /// <summary>
        /// 转发引用
        /// </summary>
        public void Charged()
        {
            Mediator.ComponetCharged(this);
        }

        public abstract void Update();
    }
}
