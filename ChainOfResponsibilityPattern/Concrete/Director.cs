using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Concrete
{
    /// <summary>
    /// 具体处理者--主任
    /// </summary>
    public class Director : Approver
    {
        public Director(string name) : base(name)
        {
        }

        /// <summary>
        /// 主任处理金额小于5万的采购单
        /// </summary>
        /// <param name="request"></param>
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amout<50000)
            {
                Console.WriteLine($"主任处理采购单号：{request.Number},金额：{request.Amout},目的：{request.Purpose}");
            }
            else
            {
                this.successer.ProcessRequest(request);//不满足要求传递给下一个
            }
        }
    }
}
