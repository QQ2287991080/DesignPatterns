using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 简单工厂模式：定义一个工厂类，它可以根据参数的不同返回不同类的实例，被创建的实例通常都具有共同的父类。
    /// </summary>
    public static class Factory
    {
        public static Product GetProduct(string productName)
        {
            Product product = null;
            if (productName.Equals("电脑"))
            {
                product = new Computer();
            }
            else if (productName.Equals("手机"))
            {
                product = new Phone();
            }
            return product;
        }
    }
    /// <summary>
    /// 首先声明一个产品父类
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// 声明公共方法
        /// </summary>
        public void Production()
        {
            Console.WriteLine("生产零件");
        }
        /// <summary>
        /// 声明抽象方法
        /// </summary>
        public abstract void WhatProduction();
    }
    /// <summary>
    /// 我有一个手机的产品
    /// </summary>
    public class Phone : Product
    {
        public override void WhatProduction()
        {
            Console.WriteLine("生产手机");
        }
    }
    /// <summary>
    ///一个电脑产品
    /// </summary>
    public class Computer : Product
    {
        public override void WhatProduction()
        {
            Console.WriteLine("生产电脑");
        }
    }

}
