using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 按钮，具体同事类
    /// </summary>
    public class Button : MediatorPattern.Compoent
    {
        public override void Update()
        {
            //按钮不响应
        }
    }
}
