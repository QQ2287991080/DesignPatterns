using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 距离节点类，充当终结符表达式角色
    /// </summary>
    public class DistanceNode : INode
    {

        private string _distance;
        public DistanceNode(string distance)
        {
            _distance = distance;
        }
        public string Interpret()
        {
            return this._distance;
        }
    }
}
