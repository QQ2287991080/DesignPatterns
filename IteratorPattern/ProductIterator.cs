using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
  public  class ProductIterator : AbstractIterator
    {
        private ProductList productList;
        private List<object> product;
        private int cursors1;//定义一个游标，用于记录正向遍历的位置
        private int cursors2;//定义一个游标，用于记录反向遍历的位置
        public ProductIterator(ProductList  list)
        {
            this.productList = list;
            product = list.GetObjects();//获取集合对象
            cursors1 = 0;//设置正向遍历初始值
            cursors2 = product.Count - 1;//设置反向遍历初始值
        }

        public void Next()
        {
            if (cursors1<product.Count)
            {
                cursors1++;
            }
        }
        public bool IsLast()
        {
            return cursors1 == product.Count;//正向游标是否等于聚合对象的总数量
        }

        public void Previous()
        {
            if (cursors2>-1)//判断反向游标是否大于-1，如果大于说明超过了聚合对象的第一项的索引。
            {
                 cursors2--;
            }
        }
        public bool IsFirst()
        {
            return cursors2 == -1;//返回
        }
        public object GetNextItem()
        {
            return product[cursors1];
        }

        public object GetPreviousItem()
        {
            return product[cursors2];
        }
    }
}
