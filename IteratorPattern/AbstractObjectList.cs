using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 抽象聚合类
    /// </summary>
    public abstract class AbstractObjectList
    {
        protected List<object> objects = new List<object>();

        public AbstractObjectList(List<object>objects)
        {
            this.objects = objects;
        }

        public void Add(object obj)
        {
            this.objects.Add(obj);
        }
        public void Remove(object obj)
        {
            this.objects.Remove(obj);
        }

        public List<Object> GetObjects()
        {
            return this.objects;
        }
        /// <summary>
        /// 生命迭代器对象的抽象工厂方法
        /// </summary>
        /// <returns></returns>
        public abstract AbstractIterator CreateIterator();
        
    }
}
