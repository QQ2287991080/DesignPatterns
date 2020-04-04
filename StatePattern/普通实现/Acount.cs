using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.普通实现
{
    /// <summary>
    /// 环境类
    /// </summary>
    public class Acount
    {
        private AcountState state;//维持一个抽象状态的引用
        private string owner;
        private double blance = 0;

        public Acount(string owin, double blance)
        {
            this.blance = blance;
            this.owner = owin;
            this.state = new NormalState(this);//设置初始状态
            Console.WriteLine($"开启账户余额{this.blance}");
        }

        public double Balance { get => blance; set => this.blance = value; }
        public string Owner { get => owner; set => this.owner = value; }

        public void SetState(AcountState state)
        {
            this.state = state;
        }
        public void Deposit(double amount)
        {
            Console.WriteLine($"{this.Owner}存款{this.Balance}");
            state.Deposit(amount);
            Console.WriteLine($"现在余额为{this.Balance}");
            Console.WriteLine($"现在账户的状态为{this.state.GetType().ToString()}");
            Console.WriteLine("=====================================");
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine($"{this.Owner}取款{this.Balance}");
            state.Withdraw(amount);
            Console.WriteLine($"现在余额为{this.Balance}");
            Console.WriteLine($"现在账户的状态为{this.state.GetType().ToString()}");
            Console.WriteLine("=====================================");
        }
        public void ComputeInterest()
        {
            state.ComputeInterest();
        }


    }
}
