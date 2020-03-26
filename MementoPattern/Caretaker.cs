using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 负责人类
    /// </summary>
   public class Caretaker
    {
        private Memento Memento;

        internal Memento GetMemento()
        {
            return Memento;
        }
        internal void SetMemento(Memento memento)
        {
            this.Memento = memento;
        }
    }
    /// <summary>
    /// 多步撤销
    /// </summary>
    public class ManyCaretaker
    {
        private List<Memento> Memento=new List<Memento>();

        internal Memento GetMemento(int i)
        {
            return Memento[i];
        }
        internal void SetMemento(Memento memento)
        {
            this.Memento.Add(memento);
        }
    }
}
