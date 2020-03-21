using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyValidattor
    {
        //模拟用户登录
        public bool Validate(string userId)
        {

            Console.WriteLine("正在查询......");
            Thread.Sleep(3000);
            if (userId.Equals("Zero"))
            {
                Console.WriteLine("登录成功！");
                return true;
            }
            else
            {
                Console.WriteLine("登陆失败！");
                return false;
            }
        }
    }
}
