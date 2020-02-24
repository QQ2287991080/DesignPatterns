using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// 工厂方法模式：定义一个用于创建对象的接口，但是让子类决定将哪一个类实例化，工厂方法模式让一个类的实例化延迟到其子类。
    /// </summary>
    /// 抽象工厂

    public interface IFactory
    {
        IFruits WhatProduct();
        /// <summary>
        /// 重载方法
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IFruits WhatProduct(string name);
    }



}
