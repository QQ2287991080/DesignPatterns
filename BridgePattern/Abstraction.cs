using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 另一层抽象部分
    /// </summary>
    public abstract class Abstraction
    {
        protected Implementor Implementor;//定义实现类接口对象
        public void SetImp1(Implementor implementor)
        {
            Implementor = implementor;
        }

        public abstract void OperationImp();//声明抽象方法
    }

    public class RefinedAbstraction : Abstraction
    {
        public override void OperationImp()
        {
            Implementor.OperationImp();

        }
    }
}
