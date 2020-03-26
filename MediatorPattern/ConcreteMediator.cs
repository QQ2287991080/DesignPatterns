using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 具体抽象者
    /// </summary>
    public class ConcreteMediator : Mediator
    {

        // 维持对各同事对象的引用
        public Button Button;
        public ListView ListView;
        public TextBox TextBox;
        public void ComponetCharged(Compoent c)
        {
            //按钮
            if (c==Button)
            {
                Console.WriteLine("单机按钮");
                ListView.Update();
            }
            else if (c==ListView)
            {
                Console.WriteLine("从列表选择客户");
                TextBox.Update();
            }
            else
            {
                Console.WriteLine("清除文本框");
            }
        }
    }
}
