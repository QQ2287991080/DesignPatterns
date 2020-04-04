using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.普通实现
{
    /// <summary>
    /// 抽象状态类
    /// </summary>
    public abstract class AcountState
    {
        private Acount acc;
        public Acount Acc
        {
            get => acc; set => acc = value;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void ComputeInterest();
        public abstract void StateCheck();

    }
}
