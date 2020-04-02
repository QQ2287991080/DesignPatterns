using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 指令处理类
    /// </summary>
  public  class InstruetionHandler
    {
        private INode _node;
        public void Handle(string str)
        {
            INode left = null, right = null, direction = null, action = null, distance = null;
            Stack stack = new Stack();//声明一个栈对象用于存储抽象语法树
            string[] words = str.Split(' ');//以空格分隔字符串
            for (int i = 0; i < words.Length; i++)
            {
                ///本实例采用栈的方式处理指令，如果遇到and，则将其后的三个单词作为三个终结符表达式连成一个简单的SentenceNode作为and的右表达式，而将从栈顶弹出的表达式作为and的左表达式，最后将新的and表达式压入栈
                if (words[i].Equals("and"))
                {
                    left = (INode)stack.Pop();//弹出栈顶表达式作为左表达式
                    string word1 = words[++i];
                    direction = new DirectionNode(word1);//判断方向
                    string word2 = words[++i];
                    action = new ActionNode(word2);//判断动作
                    string word3 = words[++i];
                    distance = new DistanceNode(word3);//判断距离
                    right = new SentenceNode(direction, action, distance);//右表达式
                    stack.Push(new AndNode(left,right));//将新表达式压入栈中
                }
                else
                {
                    string word1 = words[i];
                    direction = new DirectionNode(word1);//判断方向
                    //var xx = ++i;
                    string word2 = words[++i];
                    action = new ActionNode(word2);//判断动作
                    string word3 = words[++i];
                    distance = new DistanceNode(word3);//判断距离
                    left = new SentenceNode(direction, action, distance);//右表达式
                    stack.Push(left);//将新表达式压入栈中
                }
            }
            _node = (INode)stack.Pop();//将全部表达式从栈中弹出
        }
        public string Output()
        {
            return _node.Interpret();
        }
    }
}
