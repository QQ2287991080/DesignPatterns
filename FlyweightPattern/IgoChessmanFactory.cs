
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// 享元工厂
    /// </summary>
   public class IgoChessmanFactory
    {
        private static IgoChessmanFactory factory = new IgoChessmanFactory();
        private Hashtable ht;//使用hashtable来存储享元对象，充当享元池

        private IgoChessmanFactory()
        {
            ht = new Hashtable();
            IgoChessman black = new BlackChessman();
            IgoChessman white = new WhiteChessman();
            ht.Add("b", black);
            ht.Add("w", white);
        }

        public static IgoChessmanFactory GetIntance()
        {
            return factory;
        }
        /// <summary>
        /// 通过key获取享元池中的对象
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public  IgoChessman GetIgoChessman(string color)
        {
            return ht[color] as IgoChessman;
        }
    }
}
