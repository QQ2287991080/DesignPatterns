using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 简单句子节点类，充当非终结符表达式角色
    /// </summary>
    public class SentenceNode : INode
    {
        private INode _direction;
        private INode _action;
        private INode _distance;
        public SentenceNode(INode direction, INode action, INode distance)
        {
            _action = action;
            _direction = direction;
            _distance = distance;
        }
        public string Interpret()
        {
            return _direction.Interpret() + _action.Interpret() + _distance.Interpret();
        }
    }
}
