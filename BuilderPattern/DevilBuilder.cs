using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 恶魔
    /// </summary>
    public class DevilBuilder : ActorBuilder
    {
        public override void BuildName()
        {
            actor.Name = "莫甘娜";
        }

        public override void BuildType()
        {
            actor.Type = "堕落天使";
        }
        /// <summary>
        /// 根据需要重写钩子方法
        /// </summary>
        /// <returns></returns>
        public override bool IsGood()
        {
            return true;
        }
    }
}
