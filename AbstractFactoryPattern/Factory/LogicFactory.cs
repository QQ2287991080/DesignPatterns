using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    public class LogicFactory
    {
        public ISkinFactory CheckFacotry(SkinType skinType)
        {
            ISkinFactory skinFactory = null;
            switch (skinType)
            {
                case SkinType.Minimalism:
                    skinFactory = new MinimalismFactory();
                    break;
                case SkinType.Trend:
                    skinFactory = new TrendFactory();
                    break;
            }
            return skinFactory;
        }
    }

    public enum SkinType
    {
        /// <summary>
        /// 极简
        /// </summary>
        Minimalism= 0,
        /// <summary>
        /// 潮流
        /// </summary>
        Trend=1
    }
     
}
