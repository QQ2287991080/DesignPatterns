using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class WhiteChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "白色";
        }
    }
}
