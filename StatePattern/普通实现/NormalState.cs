using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.普通实现
{
    /// <summary>
    /// 具体实现状态类--正常状态
    /// </summary>
   public class NormalState : AcountState
    {
        public NormalState(Acount acount)
        {
            this.Acc = acount;
        }
        public NormalState(AcountState state)
        {
            this.Acc = state.Acc;
        }
        public override void ComputeInterest()
        {
            Console.WriteLine("正常状态");
        }

        public override void Deposit(double amount)
        {
            Acc.Balance += amount;
            StateCheck();
        }

        public override void StateCheck()
        {
            if (Acc.Balance>-2000&&Acc.Balance<=0)
            {
                Acc.SetState(new OverdraftState(this));
            }
            else if (Acc.Balance==-2000)
            {
                Acc.SetState(new RestrictedState(this));
            }
            else if (Acc.Balance<-2000)
            {
                Console.WriteLine("取款失败");
                Acc.Balance += amout;
            }
        }
        private double amout;
        public override void Withdraw(double amount)
        {
            Acc.Balance -= amount;
            amout = amount;
            StateCheck();
        }
    }
}
