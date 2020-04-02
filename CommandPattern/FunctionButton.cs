using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 请求者
    /// </summary>
    public class FunctionButton
    {
        private Command command;
        /// <summary>
        /// 为功能注入命令
        /// </summary>
        public Command Command
        {
            get { return command; }
            set { command = value; }
        }
        /// <summary>
        /// 发送请求
        /// </summary>
        public void Click()
         {
            Console.WriteLine("开始发送请求");
            command.Excute();
            Console.WriteLine("请求结束");
        }
        /// <summary>
        /// 发送多个请求
        /// </summary>
        public void Clicks(CommandQueue queue)
        {
            queue.Excute();
        }

    }
}
