using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Factory;
using AdapterPattern;
using AdapterPattern.DefaultAdapterPattern;
using BridgePattern;
using BuilderPattern;
using DecoratorPattern;
using FacadePattern;
using FactoryPattern;
using PrototypePattern;
using SimpleFactoryPattern;
using SingletonPattern;
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
                    //ActorController controller = new ActorController();//实例化指挥者
                    //ActorBuilder builder = new AngleBuilder();//创建天使
                    //Actor actor = controller.Construct(builder);//返回角色具体的信息
                    //Console.WriteLine(actor.Type);
                    //Console.WriteLine(actor.Name);

                }
                {
                    //ActorController controller = new ActorController();//实例化指挥者
                    //ActorBuilder builder = new DevilBuilder();//创建恶魔
                    //Actor actor = controller.Construct(builder);//返回角色具体的信息
                    //Console.WriteLine(actor.Type);
                    //Console.WriteLine(actor.Name);
                }
                {
                    //合并指挥者和抽象建造者
                    //AngleBuilder angle = new AngleBuilder();
                    //Actor actor = ActorBuilder.CreateActor(angle);
                    //Console.WriteLine(actor.Type);
                    //Console.WriteLine(actor.Name);
                }
                {
                    //原型模式:使用原型实例指定待创建对象的类型，并且通过复制这个原型来创建新的对象
                    {
                        //通用实现
                        //ConcretePrototype prototype = new ConcretePrototype();
                        //prototype.Attr = "机器人壹号";
                        //ConcretePrototype copy = (ConcretePrototype)prototype.Clone();
                        //Console.WriteLine("克隆"+copy.Attr);
                        //Console.WriteLine(prototype==copy);//false--虽然复制了对象但是内存中的对象副本不是同一个所以他们是不相等的
                        //Console.WriteLine(prototype.Attr==copy.Attr);//false 
                    }
                    {
                        //c#中的 MemberwiseClone和 ICloneable
                        //MemberwiseClone实现浅克隆
                        //ConcretePrototypeA prototype = new ConcretePrototypeA();
                        //var copy = (ConcretePrototypeA)prototype.Clone();
                        //Console.WriteLine(copy==prototype);
                        //Console.WriteLine(copy.Member==prototype.Member);//ture  --复制后的两个对象相等说明是浅克隆
                    }
                    {
                        //ICloneable实现深克隆
                        //ConcretePrototypeB prototype = new ConcretePrototypeB();
                        //var copy = (ConcretePrototypeB)prototype.Clone();
                        //Console.WriteLine(copy == prototype);//false
                        //Console.WriteLine(copy.Member == prototype.Member);//false
                    }

                }
                {
                    ////单例模式：确保一个类只有一个实例，并提供一个全局访问点来访问这个唯一的实例。
                    //{
                    //    //普通
                    //    Singleton s1 = Singleton.GetInstance();
                    //    Singleton s2 = Singleton.GetInstance();
                    //    Console.WriteLine(s1==s2);//true 

                    //}
                    //{
                    //    //饿汉式:在类被加载时就实例化自己，好处在于它是能够保证线程安全的，由于单例对象是在一开始就创建，所以调用速度和反应时间都是比懒汉式快的，但是在系统资源的利用方面饿汉式是不如懒汉式的，这很好理解，因为饿汉式是会一直占用系统资源的，但是懒汉式是需要的时候才去加载。
                    //    EagerSingleton s1 = EagerSingleton.GetIntance() ;
                    //    EagerSingleton s2 = EagerSingleton.GetIntance();
                    //    Console.WriteLine(s1==s2);

                    //}
                    //{
                    //    //懒汉式:懒汉式在第一次实例化的时候创建，但是不会一直占用系统资源，实现了延时加载，但是随之而来的问题就是多个线程同时访问的问题，特别是当单例类作为资源控制器，在实例化时必然会涉及到资源初始化，而资源初始化很有可能耗费打量的时间，这意味着出现多线程同时首次引用此类的概率会比较大，通过双重检查锁定等机制进行控制，这 将导致系统性能收到一定的影响。
                    //    LazySingleton s1 = LazySingleton.GetInstance();
                    //    LazySingleton s2 = LazySingleton.GetInstance();
                    //    Console.WriteLine(s1 == s2);
                    //}

                }

            }
            {
                ////适配器模式：将一个类的接口换成客户希望的另一个接口，适配器模式让那些接口不兼容的类可以一起工作。
                //{
                //    //类适配器 
                //    ClassAdapter adapter = new ClassAdapter();
                //    adapter.Request();
                //}
                //{
                //    //对象适配器
                //    Adaptee adaptee = new Adaptee();
                //    ObjectAdapter adapter = new ObjectAdapter(adaptee);
                //    adapter.Request();
                //}
                //{
                //    //缺省适配器模式
                //    ConcreteService service = new ConcreteService();
                //    service.Face1();
                //}
                //{
                //    //双向适配器模式
                //    Adaptee adaptee = new Adaptee();
                //    Twoway twoway = new Twoway(adaptee);
                //    twoway.Request();//互相只能使用对方的方法，即：适配者类使用的是request方法，目标具体类使用适配者类的方法，否者会报错，这个？？？？？？？？？？？
                //    Target target = new Target();
                //    Twoway twoway2 = new Twoway(target);
                //    twoway2.SpecificRequest();
                //}
            }

            {
                //桥接模式：将抽象部分与它的实现部分解耦，使得两者能够独立变化
                //RefinedAbstraction refined = new RefinedAbstraction();
                //ConcreteImplementor concrete = new ConcreteImplementor();
                //refined.SetImp1(concrete);
                //refined.OperationImp();
            }
            {
                //装饰模式:动态地给一个对象增加一些额外的职责。就扩展功能而言，装饰模式提供了一种比使用子类更灵活的替代方案
                {
                    //寻常调用
                    ConcreteComponent component = new ConcreteComponent();
                    ConcreteDecorator decorator = new ConcreteDecorator(component);
                    decorator.Operation();
                    decorator.Add();
                }
                {
                    //透明模式
                    Component component = new ConcreteComponent();
                    Component decorator = new ConcreteDecorator(component);
                    decorator.Operation();
                    //decorator.Add();无法单独调用该方法，但是可以放在Operation方法中一起执行

                }
                {
                    //半透明模式
                    Component component = new ConcreteComponent();//使用抽象构件类型定义
                    component.Operation();
                    ConcreteDecorator decorator = new ConcreteDecorator(component);//使用具体装饰定义
                    decorator.Add();//单独使用新增方法。
                }

            }
            {
                //外观模式：为子系统中的一组接口提供一个统一的入口。外观模式定义一个高层接口，这个接口是的这一子系统更容易使用。
                Facade facade = new Facade();
                facade.Meathod();
            }

            Console.ReadKey();
             
        }
    }
}
 