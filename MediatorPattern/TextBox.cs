using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 文本框类，具体同事类
    /// </summary>
    public class TextBox : MediatorPattern.Compoent
    {
        public override void Update()
        {
            Console.WriteLine("显示列表信息");
        }
    }

}
