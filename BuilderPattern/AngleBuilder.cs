using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class AngleBuilder : ActorBuilder
    {
        public override void BuildName()
        {
            actor.Name = "凯尔";
        }

        public override void BuildType()
        {
            actor.Type = "正义天使";
        }
    }
}
