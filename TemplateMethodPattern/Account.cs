using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class Account
    {
        /// <summary>
        /// 具体方法
        /// </summary>
        public bool Validate(string name)
        {
            if (name.Equals("Zero"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //抽象方法
        public virtual void Call()
        {
            Console.WriteLine("打电话给Zero");
        }

        //钩子方法
        public void Display()
        {
            Console.WriteLine("显示");
        }

        //模板方法 
        public void TemplateMethod(string name)
        {
            if (!Validate(name))
            {
                Console.WriteLine("错了,您不叫Zero");
                return;
            }
            Call();
            Display();
        }
    }
    /// <summary>
    /// 具体的子类
    /// </summary>
    public class CurrnetAccount : Account
    {
        /// <summary>
        /// 根据自己的需求重写父类的方法
        /// </summary>
        public override void Call()
        {
            Console.WriteLine("嘟嘟嘟。打电话给Zero");
        }
    }
}
