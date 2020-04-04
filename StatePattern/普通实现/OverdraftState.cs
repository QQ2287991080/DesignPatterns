using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.普通实现
{
    /// <summary>
    /// 透支
    /// </summary>
    public class OverdraftState : AcountState
    {
        public OverdraftState(Acount acount)
        {
            this.Acc = acount;
        }
        public OverdraftState(AcountState state)
        {
            this.Acc = state.Acc;
        }
        public override void ComputeInterest()
        {
            Console.WriteLine("计算利息");
        }

        public override void Deposit(double amount)
        {
            Acc.Balance += amount;
            StateCheck();
        }

        public override void StateCheck()
        {
            if (Acc.Balance >0)
            {
                Acc.SetState(new NormalState(this));
            }
            else if (Acc.Balance ==-2000)
            {
                Acc.SetState(new RestrictedState(this));
            }
            else if (Acc.Balance<-2000)
            {
                Console.WriteLine("账号受限"); 
            }
        }

        public override void Withdraw(double amount)
        {
            Acc.Balance -= amount;
            StateCheck();
        }
    }
}
