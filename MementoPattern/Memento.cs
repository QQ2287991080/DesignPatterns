using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 备忘录类，默认可见性，在程序及内可见
    /// </summary>
    internal class Memento
    {
        private string state;

        internal Memento(Originator originator)
        {
            state = originator.GetState();
        }

        public void SetState(string state)
        {
            this.state = state;
        }
        public string GetState()
        {
            return this.state;
        }
    }
}
