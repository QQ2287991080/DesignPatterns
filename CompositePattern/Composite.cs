using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Composite : Component
    {
        List<Component> list = new List<Component>(); 
        public void Add(Component c)
        {
            list.Add(c);
        }


        public Component Get(int i)
        {
            return list[i];
        }

        public void Operation()
        {
            foreach (var item in list)
            {
                item.Operation();
            }
        }

        public void Remove(Component c)
        {
            list.Remove(c);
        }
    }
}
