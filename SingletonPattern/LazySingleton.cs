using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
   public class LazySingleton
    {
        private static LazySingleton _instance = null;

        private readonly static object _lock = new object();

        private  LazySingleton()
        { 
        }
        public static LazySingleton GetInstance()
        {
            if (_instance==null)//第一重判断，先判断实例是否存在，不存在再加锁处理
            {
                lock (_lock)//加锁的程序在某一时刻只允许一个线程访问
                {
                    //第二重判断
                    if (_instance==null)
                    {
                        _instance = new LazySingleton();
                    }
                }
            }
            return _instance;
        }

    }
}
