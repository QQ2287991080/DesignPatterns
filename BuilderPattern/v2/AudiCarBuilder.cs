using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.v2
{

    public class AudiCarBuilder : CarBuilder
    {
        public override void BuilderBody()
        {
            _car.Body = "豪华车身";
        }

        public override void BuilderChassis()
        {
            _car.Chassis = "贵族底盘";
        }

        public override void BuilderElectrical()
        {
            _car.Electrical = "史诗级电气设备，100000000w超级喷射";
        }

        public override void BuilderEngine()
        {
            _car.Engine = "行星级发动机";
        }
    }
}
