using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.v2
{

    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class CarBuilder
    {
        protected Car _car;

        /*
         抽象方法
         */
        public abstract void BuilderEngine();
        public abstract void BuilderChassis();
        public abstract void BuilderBody();
        public abstract void BuilderElectrical();


        public CarBuilder()
        {
            _car = new Car();
        }


        public Car CreateCar()
        {
            return _car;
        }
    }
}
