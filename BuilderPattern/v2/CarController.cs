using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.v2
{


    /// <summary>
    /// 指挥者
    /// </summary>
    public class CarController
    {
        /// <summary>
        /// 构建一辆汽车
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public Car Construct(CarBuilder builder)
        {

            //可以调整你想要的顺序
            builder.BuilderBody();
            builder.BuilderChassis();
            builder.BuilderElectrical();
            builder.BuilderEngine();

            return builder.CreateCar();
        }
    }
}
