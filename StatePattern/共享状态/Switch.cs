using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.共享状态
{
    /// <summary>
    /// 环境类
    /// </summary>
  public class Switch
    {
        private static SwitchState currentState,onState,offState;
        private string name;
        public Switch(string name)
        {
            this.name=name;
            onState =new OnState();
            offState = new OffState();
            currentState = onState;

        }
        public string Name { get => name; set => name = value; }

        public void SetState(SwitchState state)
        {
            currentState = state;
        }
        public static SwitchState GetState(string type)
        {
            if (type.Equals("on"))
            {
                return onState;
            }
            else
            {
                return offState;
            }
        }

        public void Off()
        {
            Console.WriteLine(name);
            currentState.Off(this);
        }

        public void On()
        {
            Console.WriteLine(name);
            currentState.On(this);
        }
    }


    public abstract class SwitchState
    {
        public abstract void On(Switch s);
        public abstract void Off(Switch s);
    }


    public class OnState : SwitchState
    {
        public override void Off(Switch s)
        {
            Console.WriteLine("关闭");
            s.SetState(Switch.GetState("off"));
        }

        public override void On(Switch s)
        {
            Console.WriteLine("打开");
        }
    }
    public class OffState : SwitchState
    {
        public override void Off(Switch s)
        {
            Console.WriteLine("关闭");
        }

        public override void On(Switch s)
        {
            Console.WriteLine("打开");
            s.SetState(Switch.GetState("on"));
        }
    }
}
