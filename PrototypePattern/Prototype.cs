using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// 抽象原型类
    /// </summary>
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    /// <summary>
    /// 具体实现类
    /// </summary>
    public class ConcretePrototype : Prototype
    {
        private string attr;

        public string Attr
        {
            get { return attr; }
            set { attr = value; }
        }

        public override Prototype Clone()
        {
            ConcretePrototype concretePrototype = new ConcretePrototype();
            concretePrototype.Attr = attr;
            Console.WriteLine("我被克隆了！！！");
            return concretePrototype;
        }
    }
}
