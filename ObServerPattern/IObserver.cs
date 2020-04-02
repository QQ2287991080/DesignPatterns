using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServerPattern
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    public interface IObserver
    {
        string Name { get; set; }
        void Help();//支援盟友
        void BeAttacked(AllyControllerCenter center);//生命遭受攻击方法
    }
}

