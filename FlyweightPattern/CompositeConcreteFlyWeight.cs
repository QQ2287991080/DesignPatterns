using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
  public  class CompositeConcreteFlyWeight
    {
        private List<(IgoChessman, Coordinates)> component = new List<(IgoChessman, Coordinates)>();

        public void Add(IgoChessman igo,Coordinates coordinates)
        {
            component.Add((igo,coordinates));
        }

        public void Display()
        {
            foreach (var item in component)
            {
                item.Item1.Display(item.Item2);
            }
        }

        public void Remove(IgoChessman igo,Coordinates coordinates)
        {
            component.Remove((igo, coordinates));
        }
        
    }
}
