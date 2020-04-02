using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
    /// <summary>
    /// 具体命令类
    /// </summary>
    public class HelpCommand : Command
    {
        
        public override void Excute()
        {
            DispalyThat dispaly = new DispalyThat();
            dispaly.Dispaly();
        }
    }
}
