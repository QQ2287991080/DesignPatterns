using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.v2
{


    /// <summary>
    /// Product
    /// </summary>
    public class Car
    {

        /// <summary>
        /// 发动机
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// 底盘
        /// </summary>
        public string Chassis { get; set; }

        /// <summary>
        /// 车声
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// 电气设备
        /// </summary>
        public string Electrical { get; set; }


    }
}
