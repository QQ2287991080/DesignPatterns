using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServerPattern
{
    /// <summary>
    /// 具体目标类
    /// </summary>
  public  class ConcreteAllyControllerCenter:AllyControllerCenter
    {
        public ConcreteAllyControllerCenter(string name)
        {
            Console.WriteLine("组件战队成功，战队名称：{0}",name);
            base.allyName = name;
        }

        /// <summary>
        /// 重写通知方法
        /// </summary>
        /// <param name="name"></param>
        public override void SendObserver(string name)
        {
            Console.WriteLine("战队成员{0}正在遭受攻击，请求支援！",name);
            //遍历观察者集合，调用除自己以外的队友
            var sendList = base.player.Where(p => !p.Name.Equals(name));
            foreach (var item in sendList)
            {
                ((IObserver)item).Help();
            }
        }
    }
}
