using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// 围棋棋子类--抽象享元类
    /// </summary>
    public abstract class IgoChessman
    {
       
        public abstract string GetColor();
        public void Display(Coordinates coordinates)
        {
            Console.WriteLine("棋子颜色："+GetColor()+"位置："+coordinates.X+coordinates.Y);
        }
        
    }
}
