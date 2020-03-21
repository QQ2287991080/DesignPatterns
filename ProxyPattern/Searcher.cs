using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 抽象查询类
    /// </summary>
  public  interface Searcher
    {
        string DoSearch(string userId, string key);
    }
    /// <summary>
    /// 具体查询类
    /// </summary>
    public class RealSearcher : Searcher
    {
        public string DoSearch(string userId, string key)
        {
            Console.WriteLine("用户：" + userId + "查询【" + key + "】");
            return "查询666";
        }
    }
    /// <summary>
    /// 代理查询类
    /// </summary>
    public class ProxySearcher : Searcher
    {
        private RealSearcher searcher = new RealSearcher();//引用具体查询类
        private ProxyValidattor validattor;
        private Logger logger;
        public string DoSearch(string userId, string key)
        {
            if (this.Vaildate(userId))
            {
                string result = searcher.DoSearch(userId, key);
                this.Log(userId);
                return result;
            }
            else
            {
                return null;
            }
        }

        public bool Vaildate(string userId)
        {
            validattor = new ProxyValidattor();
            return validattor.Validate(userId);
        }
        public void Log(string userId)
        {
            logger = new Logger();
            logger.Log(userId);
        }
    }
}
