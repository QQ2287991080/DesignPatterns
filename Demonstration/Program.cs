using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Factory;
using BuilderPattern;
using FactoryPattern;
using SimpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //简单工厂模式：定义一个工厂类，它可以根据参数的不同返回不同类的实例，被创建的实例通常都具有共同的父类。
                //Product product = Factory.GetProduct("电脑");
                //product.Production();
                //product.WhatProduction();
            }
            {
                //工厂方法模式：定义一个用于创建对象的接口，但是让子类决定将哪一个类实例化，工厂方法模式让一个类的实例化延迟到其子类。
                //IFactory factory = new AppleFactory();
                //IFruits fruits = factory.WhatProduct("");
                //fruits.CreateFruits();
                //优点：相比于简单工厂模式，工厂模式的拓展性更加的好。
                //工厂方法用来创建客户端所需要的东西，但是隐藏了具体实例化的细节。
                //缺点：每次新增加一个产品需要些一个具体的产品，和产品的工厂类。。。。
            }
            {
                //抽象工厂模式：提供一个创建一系列相关或相互依赖对象的接口，而无需指定他们具体的类

                //LogicFactory logicFactory = new LogicFactory();
                //ISkinFactory factory = logicFactory.CheckFacotry(SkinType.Trend);
                //IButton button = factory.CreateButton();
                //ICheckBox checkBox = factory.CreateCheckBox();
                //button.Display();
                //checkBox.Display();

            }
            {
                //建造者模式:讲一个辅助对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。

                {
                    //一般情况
                    ActorController controller = new ActorController();//实例化指挥者
                    ActorBuilder builder = new AngleBuilder();//创建天使
                    Actor actor = controller.Construct(builder);//返回角色具体的信息
                    Console.WriteLine(actor.Type);
                    Console.WriteLine(actor.Name);



                }
                {
                    ActorController controller = new ActorController();//实例化指挥者
                    ActorBuilder builder = new DevilBuilder();//创建恶魔
                    Actor actor = controller.Construct(builder);//返回角色具体的信息
                    Console.WriteLine(actor.Type);
                    Console.WriteLine(actor.Name);
                }
                {
                    //合并指挥者和抽象建造者
                    //AngleBuilder angle = new AngleBuilder();
                    //Actor actor = ActorBuilder.CreateActor(angle);
                    //Console.WriteLine(actor.Type);
                    //Console.WriteLine(actor.Name);
                }
                { 
                //原型模式


                }
                {
                    //单例模式
                    { 
                    //普通
                    }
                    { 
                    //饿汉式
                    }
                    { 
                    //懒汉式
                    }

                }










            }
            Console.ReadKey();

        }
    }
}
