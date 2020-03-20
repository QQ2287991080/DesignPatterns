using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 审批者类（抽象）
    /// </summary>
   public abstract class Approver
    {
        protected Approver successer;//定义后继对象
        protected string name;//审批者名称
        public Approver(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 设置后继对象
        /// </summary>
        /// <param name="approver"></param>
        public void SetSuccesser(Approver approver)
        {
            successer = approver;
        }
        /// <summary>
        /// 抽象处理方法
        /// </summary>
        /// <param name="request"></param>
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}
