using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 原发器
    /// </summary>
    public class Originator
    {

        private string state;
        public Originator(string state)
        {
            this.state=state;
        }
        //创建一个备忘录对象
        internal Memento CreateMemento()
        {
            return new Memento(this);
        }
        //根据备忘录对象恢复原发器的状态
        internal void RestoreMemento(Memento memento)
        {
            state = memento.GetState();
        }
        public void SetState(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }
    }
}
