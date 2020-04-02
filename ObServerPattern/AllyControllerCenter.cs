using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServerPattern
{


    /*在一个多人联机的对战游戏中，多个玩家可以加入一个战队组成一个联盟，当战队中的一名成员受到敌人的攻击是，将给其他的所有成员发送通知，名优收到通知将做出响应*/
    /// <summary>
    /// 抽象目标类
    /// </summary>
    public abstract class AllyControllerCenter
    {
        protected string allyName;//战队名称
        protected List<IObserver> player = new List<IObserver>();//定义一个集合用于保存战队成员

        /// <summary>
        /// 设置战队名称
        /// </summary>
        /// <param name="name"></param>
        public void SetAllyName(string name)
        {
            allyName = name;
        }
        /// <summary>
        /// 获取战队名称
        /// </summary>
        /// <returns></returns>
        public string GetAllyName()
        {
            return this.allyName;
        }
        /// <summary>
        /// 添加玩家
        /// </summary>
        /// <param name="observer"></param>
        public void AddPlayer(IObserver observer)
        {
            Console.WriteLine($"玩家{observer.Name}加入战队");
            player.Add(observer);
        }
        /// <summary>
        /// 玩家退出
        /// </summary>
        /// <param name="observer"></param>
        public void RemovePlayer(IObserver observer)
        {
            Console.WriteLine($"玩家{observer.Name}退出战队");
            player.Remove(observer);
        }
        //申明抽象通知方法
        public abstract void SendObserver(string name);
    }
}
