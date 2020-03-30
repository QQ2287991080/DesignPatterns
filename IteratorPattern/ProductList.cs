using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 具体聚合类
    /// </summary>
    public class ProductList : AbstractObjectList
    {
        public ProductList(List<object> objects) : base(objects)
        {

        }
        /// <summary>
        /// 实现创建迭代器对象具体的工厂方法
        /// </summary>
        /// <returns></returns>
        public override AbstractIterator CreateIterator()
        {
            return new ProductIterator(this);
        }
    }
}
