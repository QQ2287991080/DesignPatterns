using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
  public  class Execute
    {
        /// <summary>
        /// 单个撤销
        /// </summary>
        public static void Invoke()
        {
            //创建原发器对象
            Originator originator = new Originator("状态1");
            Console.WriteLine(originator.GetState());
            //创建负责人对象
            Caretaker caretaker = new Caretaker();
            caretaker.SetMemento(originator.CreateMemento());

            originator.SetState("状态2");
            Console.WriteLine(originator.GetState());

            //从负责人对象中取出备忘录对象
            originator.RestoreMemento(caretaker.GetMemento());
            Console.WriteLine(originator.GetState()); 
        }
        /// <summary>
        /// 多次撤销
        /// </summary>
        public static void Invokes()
        {
            Console.WriteLine("=====================多次撤销====================");
            //创建原发器对象
            Originator originator = new Originator("状态1");
            Play(originator);
            originator.SetState("状态2");
            Play(originator);
            //撤销状态2
            Console.WriteLine("=====================准备撤销====================");
            Undo(originator, Index);
            //取消撤销
            Console.WriteLine("=====================取消撤销====================");
            Redo(originator, Index);
            //补加状态3
            Console.WriteLine("=====================新增状态====================");
            originator.SetState("状态3");
            Play(originator);
        }

        private static int Index = -1;//定义一个索引记录当前状态所在的位置
        private static ManyCaretaker ManyCaretaker = new ManyCaretaker();

        public static void Play(Originator o)
        {
            ManyCaretaker.SetMemento(o.CreateMemento());
            Index++;
            Console.WriteLine(o.GetState());
            Console.WriteLine("攻击");
        }

        public static void Undo(Originator o,int i)
        {
            ManyCaretaker.SetMemento(o.CreateMemento());
            Index--;
            o.RestoreMemento(ManyCaretaker.GetMemento(i - 1));
            Console.WriteLine(o.GetState());
            Console.WriteLine("撤销攻击");
        }
        public static void Redo(Originator o,int i)
        {
            ManyCaretaker.SetMemento(o.CreateMemento());
            Index++;
            o.RestoreMemento(ManyCaretaker.GetMemento(i + 1));
            Console.WriteLine(o.GetState());
            Console.WriteLine("撤销撤销攻击");
        }
    }
}
