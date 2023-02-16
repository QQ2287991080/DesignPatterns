using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.v2
{
    public class BenzCarBuilder : CarBuilder
    {
        public override void BuilderBody()
        {
            _car.Body = "镶钻车身";
        }

        public override void BuilderChassis()
        {
            _car.Chassis = "真空底盘";
        }

        public override void BuilderElectrical()
        {
            _car.Electrical = "100000000w超级喷射";
        }

        public override void BuilderEngine()
        {
            _car.Engine = "恒星级发动机";
        }
    }
}
