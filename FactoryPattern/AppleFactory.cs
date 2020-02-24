using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class AppleFactory : IFactory
    {
        public IFruits WhatProduct()
        {
            Console.WriteLine("苹果");
            return new Apple();
        }

        public IFruits WhatProduct(string name)
        {
            Console.WriteLine("这是超级好吃的苹果哦");
            return new Apple();
        }
    }
}
