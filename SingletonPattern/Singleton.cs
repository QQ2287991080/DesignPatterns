using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton install = null;//静态私有成员

        //私有构造函数
        private Singleton()
        { 
        }
        //静态共有工厂方法，返回唯一实例
        public static Singleton GetInstance()
        {
            if (install==null)
            {
                install = new Singleton();
            }
            return install;
        }
    }
}
