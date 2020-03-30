using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 具体命令类
    /// </summary>
    public class ExitCommand : Command
    {
        private Exit exit;
        public ExitCommand()
        {
            exit = new Exit();
        }
        public override void Excute()
        {
            exit.Excute();
        }
    }
}
