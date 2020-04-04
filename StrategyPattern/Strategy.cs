using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    ///策略环境类
    /// </summary>
   public class Strategy
    {
        private double price;
        private Discount discount;//抽象引用
        public double Price
        {
            get { return this.discount.Calculate(price)  ; }//计算折扣
            set { price   = value; }
        }
        public void SetDiscount(Discount discount)
        {
            this.discount = discount;
        }

    }

    /// <summary>
    /// 抽象策略类
    /// </summary>
    public abstract class Discount
    {
        /// <summary>
        /// 计算折扣
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public abstract double Calculate(double price);
    }

    /// <summary>
    /// 具体策略类
    /// </summary>
    public class Student : Discount
    {
        private const double DISCOUNT = 0.8;
        public override double Calculate(double price)
        {
            Console.WriteLine("滴：学生票");
            return price * DISCOUNT;
        }
    }
    public class Children : Discount
    {
        private const double DISCOUNT = 10;
        public override double Calculate(double price)
        {
            Console.WriteLine("滴：儿童票");
            return price - DISCOUNT;
        }
    }

}
