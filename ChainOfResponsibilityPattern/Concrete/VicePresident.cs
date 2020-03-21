using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Concrete
{
    /// <summary>
    /// 具体处理者--副董事长
    /// </summary>
    public class VicePresident : Approver
    {
        public VicePresident(string name) : base(name)
        {
        }

        /// <summary>
        /// 副董事长处理金额小于15万的
        /// </summary>
        /// <param name="request"></param>
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amout < 150000)
            {
                Console.WriteLine($"副董事长处理采购单号：{request.Number},金额：{request.Amout},目的：{request.Purpose}");
            }
            else
            {
                this.successer.ProcessRequest(request);//不满足要求传递给下一个
            }
        }
    }
}
