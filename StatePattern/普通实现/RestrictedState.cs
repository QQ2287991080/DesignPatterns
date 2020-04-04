using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.普通实现
{
    public class RestrictedState : AcountState
    {
        public RestrictedState(Acount acount)
        {
            this.Acc = acount;
        }
        public RestrictedState(AcountState state)
        {
            this.Acc = state.Acc;
        }
        public override void ComputeInterest()
        {
            Console.WriteLine("账号受限,取款失败");
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
            else if (Acc.Balance > -2000)
            {
                Acc.SetState(new OverdraftState(this));
            }
        }

        public override void Withdraw(double amount)
        {
            Acc.Balance -= amount;
            StateCheck();
        }
    }
}
