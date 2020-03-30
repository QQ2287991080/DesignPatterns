using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// and节点类，充当非终结符表达式角色
    /// </summary>
    public class AndNode : INode
    {
        private INode _left;
        private INode _right;
        public AndNode(INode left,INode right)
        {
            _left = left;
            _right = right;
        }
        public string Interpret()
        {
            return _right.Interpret() + "再" + _right.Interpret();
        }
    }
}
