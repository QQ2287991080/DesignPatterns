using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServerPattern
{
    public class Player : IObserver
    {
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
        
        /// <summary>
        /// 遭受攻击方法的实现当遭受攻击时将调用目标类的通知方法
        /// </summary>
        public void BeAttacked(AllyControllerCenter center)
        {
            Console.WriteLine($"{this.Name}遭到攻击");
            
            center.SendObserver(this.Name);
        }
        /// <summary>
        /// 实现帮助盟友方法
        /// </summary>
        public void Help()
        {
            Console.WriteLine($"{Name}正在支援");
        }
    }
}
