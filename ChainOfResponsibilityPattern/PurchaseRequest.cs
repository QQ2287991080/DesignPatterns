using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 采购类，充当请求类
    /// </summary>
    public class PurchaseRequest
    {

        public PurchaseRequest(double amout,int number,string purpose)
        {
            this.amout = amout;
            this.number = number;
            this.purpose = purpose;
        }
        private double amout;  //采购金额  

        public double Amout
        {
            get { return amout; }
            set { amout = value; }
        }

        private int number;//采购单号

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private string purpose;//采购目的

        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }

    }
}
