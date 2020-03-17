using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// 具体享元对象
    /// </summary>
    public class BlackChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "黑色";
        }
    }
}
