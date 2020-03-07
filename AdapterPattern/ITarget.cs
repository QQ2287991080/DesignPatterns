using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
  /// <summary>
  /// 目标抽象类
  /// </summary>
   public interface ITarget
    {
        void Request();
    }
}
