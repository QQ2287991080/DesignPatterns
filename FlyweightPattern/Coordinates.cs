using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
  /// <summary>
  /// 坐标类--作为外部状态
  /// </summary>
   public class Coordinates
    {
		public Coordinates(int x,int  y)
		{
			this.x = x;
			this.y = y;
		}
		private int x;
		public int X
		{
			get { return x; }
			set { x = value; }
		}
		private int y;
		public int Y
		{
			get { return y; }
			set { y = value; }
		}



	}
}
