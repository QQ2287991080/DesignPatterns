using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class ActorBuilder
    {
        protected Actor actor = new Actor();

        public abstract void BuildType();
        public abstract void BuildName();
        /// <summary>
        /// 工厂方法，返回一个具体的角色
        /// </summary>
        /// <returns></returns>
        public Actor CreateActor()
        {
            return actor;
        }
        /// <summary>
        /// 增加钩子方法判断特殊情况
        /// </summary>
        /// <returns></returns>
        public virtual bool IsGood()
        {
            return false;
        }
       
    }



    //public abstract class ActorBuilder
    //{
    //    protected static Actor actor = new Actor();

    //    public abstract void BuildType();
    //    public abstract void BuildName();
    //    /// <summary>
    //    /// 工厂方法，返回一个具体的角色
    //    /// </summary>
    //    /// <returns></returns>

    //    /// <summary>
    //    /// 当抽象角色和指挥者合并
    //    /// </summary>
    //    /// <param name="builder"></param>
    //    /// <returns></returns>
    //    public static Actor CreateActor(AngleBuilder builder)
    //    {
    //        builder.BuildName();
    //        builder.BuildType();
    //        return actor;
    //    }
    //}
}
