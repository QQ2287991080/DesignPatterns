using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Factory;
using AdapterPattern;
using AdapterPattern.DefaultAdapterPattern;
using BridgePattern;
using BuilderPattern;
using ChainOfResponsibilityPattern;
using ChainOfResponsibilityPattern.Concrete;
using DecoratorPattern;
using FacadePattern;
using FactoryPattern;
using FlyweightPattern;
using IteratorPattern;
using MediatorPattern;
using MementoPattern;
using ObServerPattern;
using PrototypePattern;
using ProxyPattern;
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
                //{
                //    //寻常调用
                //    ConcreteComponent component = new ConcreteComponent();
                //    ConcreteDecorator decorator = new ConcreteDecorator(component);
                //    decorator.Operation();
                //    decorator.Add();
                //}
                //{
                //    //透明模式
                //    Component component = new ConcreteComponent();
                //    Component decorator = new ConcreteDecorator(component);
                //    decorator.Operation();
                //    //decorator.Add();无法单独调用该方法，但是可以放在Operation方法中一起执行

                //}
                //{
                //    //半透明模式
                //    Component component = new ConcreteComponent();//使用抽象构件类型定义
                //    component.Operation();
                //    ConcreteDecorator decorator = new ConcreteDecorator(component);//使用具体装饰定义
                //    decorator.Add();//单独使用新增方法。
                //}

            }
            {
                //外观模式：为子系统中的一组接口提供一个统一的入口。外观模式定义一个高层接口，这个接口是的这一子系统更容易使用。
                //Facade facade = new Facade();
                //facade.Meathod();
            }
            {
                //享元模式：运用共享技术有效的支持大量细粒度对象的复用。
                {

                    //IgoChessmanFactory factory = IgoChessmanFactory.GetIntance();
                    //var white = factory.GetIgoChessman("w");
                    //white.GetColor();
                    //white.Display(new Coordinates(1, 2));
                    //var black = factory.GetIgoChessman("b");
                    //black.GetColor();
                    //black.Display(new Coordinates(2, 1));
                }
                {
                    //复合享元对象，使多个内部状态不同的对象设置为相同的外部状态（结合组合模式使用）

                    //IgoChessmanFactory factory = IgoChessmanFactory.GetIntance();
                    //var w1= factory.GetIgoChessman("w");
                    //var w2= factory.GetIgoChessman("w");
                    //var w3= factory.GetIgoChessman("w");
                    //var w4= factory.GetIgoChessman("w");
                    //var b1= factory.GetIgoChessman("b");
                    //var b2= factory.GetIgoChessman("b");
                    //var b3= factory.GetIgoChessman("b");
                    //var b4= factory.GetIgoChessman("b");

                    //CompositeConcreteFlyWeight flyWeight = new CompositeConcreteFlyWeight();
                    //flyWeight.Add(w1, new Coordinates(1, 1));
                    //flyWeight.Add(w2, new Coordinates(1, 2));
                    //flyWeight.Add(w3, new Coordinates(1, 3));
                    //flyWeight.Add(w4, new Coordinates(1, 4));
                    //flyWeight.Add(b1, new Coordinates(2, 1));
                    //flyWeight.Add(b2, new Coordinates(2, 2));
                    //flyWeight.Add(b3, new Coordinates(2, 3));
                    //flyWeight.Add(b4, new Coordinates(2, 4));
                    //flyWeight.Display();
                    
                }

            }
            {
                //代理模式：给某一个对象提供一个代理或占位符，并由代理对象来控制对原对象的访问
                //远程代理
                //虚拟代理
                //缓冲代理
                //保护代理
                //智能引用代理
                {
                    //保护代理+智能代理
                    //ProxySearcher searcher = new ProxySearcher();
                    //searcher.DoSearch("Zero", "敏敏");
                }
            }
            {
                //职责链模式：避免将一个请求的发送者与接受者耦合在一起，让多个对象都有机会处理请求。将接受的对象连接成一条链，并且沿着这条链传递请求，知道一个对象能够处理它为止。
                //Approver approver, approver1, approver2;
                //approver = new Director("张主任");
                //approver1 = new VicePresident("张副总");
                //approver2 = new President("张总");

                ////创建职责链
                //approver.SetSuccesser(approver1);//下级传递给上一级
                //approver1.SetSuccesser(approver2);

                //PurchaseRequest request = new PurchaseRequest(5_5_0_0_0,10001,"买电脑");
                //approver.ProcessRequest(request);
            }
            {
                //迭代器模式：提供一种方法访问一个聚合元素中的各个元素，并且不暴露对象的内部表示
                //List<object> list = new List<object>();
                //list.Add("张大力");
                //list.Add("罗小敏");

                //AbstractObjectList productList = new ProductList(list);//创建聚合对象
                //AbstractIterator iterator = productList.CreateIterator();//创建迭代对象
                //while (!iterator.IsLast())//正向遍历
                //{
                //    Console.WriteLine(iterator.GetNextItem());
                //    iterator.Next();
                //}

                //while (!iterator.IsFirst())//反向遍历
                //{
                //    Console.WriteLine(iterator.GetPreviousItem());
                //    iterator.Previous();
                //}
            }
            {
                //中介者模式：定义一个对象封装一系列对象的交互，中介者模式使对象之间不需要显示的相互引用，从而使其耦合松散，而且你可以独立的改变他们之间的交互。
                //定义中介者对象
                //ConcreteMediator concrete = new ConcreteMediator();
                //定义同事对象
                //Button button = new Button();
                //ListView listView = new ListView();
                //TextBox textBox = new TextBox();
                ////设置中介者
                //button.SetMediator(concrete);
                //listView.SetMediator(concrete);
                //textBox.SetMediator(concrete);

                //concrete.TextBox = textBox;
                //concrete.ListView = listView;
                //concrete.Button = button;

                //button.Charged();
                //textBox.Charged();
                //listView.Charged();
                 




            }
            {
                //备忘录模式：在不破坏封装的情况下，捕获一个对象的内部状态，并在该对象之外保存这个状态，这样就可以将对象恢复到原先保存的状态
                //Execute.Invoke();
                //Execute.Invokes();

            }
            {
                //观察者模式：定义对象之间的一种一对多的依赖关系，使得每一个对象的状态发生改变时，其相关依赖对象得到通知并且自动更新。
                AllyControllerCenter center = new ConcreteAllyControllerCenter("王者荣耀群");

                IObserver observer, observer1, observer2, observer3, observer4;

                observer = new Player("鲁班七号");
                center.AddPlayer(observer);

                observer1 = new Player("蔡文姬");
                center.AddPlayer(observer1);

                observer2 = new Player("甄姬");
                center.AddPlayer(observer2);

                observer3 = new Player("李白");
                center.AddPlayer(observer3);

                observer4 = new Player("凯");
                center.AddPlayer(observer4);


                //鲁班被毒打
                observer.BeAttacked(center);
            }
            Console.ReadKey();
         }
    }
}
 