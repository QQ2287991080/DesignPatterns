using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    ///具体角色
    /// </summary>
    public  class Actor
    {
        private string _type;
        private string _name;

        public string Type { get { return _type; } set { _type = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        
    }
}
