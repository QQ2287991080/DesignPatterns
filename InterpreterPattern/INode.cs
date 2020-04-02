using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 抽象节点类，充当抽象表达式角色
    /// </summary>
    public interface INode
    {
        string Interpret();
    }
}
