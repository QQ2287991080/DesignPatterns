using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 方向节点类，充当终结符表达式角色
    /// </summary>
    public class DirectionNode : INode
    {
        private string _direction;
        public DirectionNode(string direction)
        {
            _direction = direction;
        }
        public string Interpret()
        {
            if (_direction.Equals("up"))
            {
                return "向上";
            }
            else if (_direction.Equals("down"))
            {
                return "向下";
            }
            else if (_direction.Equals("left"))
            {
                return "向左";
            }
            else if (_direction.Equals("right"))
            {
                return "向右";
            }
            else
            {
                return "无效指令";
            }
        }
    }
}
