using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 列表类，具体同事类
    /// </summary>
    public class ListView : MediatorPattern.Compoent
    {
        public override void Update()
        {
            Console.WriteLine("列表增加一项");
        }
    }
}
