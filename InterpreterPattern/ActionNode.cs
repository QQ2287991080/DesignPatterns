using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 动作节点类，充当终结符表达式角色
    /// </summary>
    public class ActionNode : INode
    {

        private string _action;
        public ActionNode(string action)
        {
            _action = action;
        }
        public string Interpret()
        {
            if (_action.Equals("move"))
            {
                return "移动";
            }
            else if (_action.Equals("run"))
            {
                return "快速移动";
            }

            else
            {
                return "无效指令";
            }
        }
    }
}
