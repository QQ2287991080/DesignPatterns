using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 角色指挥者
    /// </summary>
   public class ActorController
    {
        public Actor Construct(ActorBuilder builder)
        {
            builder.BuildType();
            if (builder.IsGood())
            {
                builder.BuildName();
            }
            return builder.CreateActor();
        }
    }
}
