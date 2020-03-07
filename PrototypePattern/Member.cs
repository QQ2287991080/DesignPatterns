using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{

  public  class Member
    {

    }


    public class ConcretePrototypeA : Member
    {
        private Member member;

        public Member Member {
            get { return member; }
            set { member = value; }
        }
        public ConcretePrototypeA Clone()
        {
            return (ConcretePrototypeA)this.MemberwiseClone();
        }
    }

    public class ConcretePrototypeB : ICloneable
    {
        private Member member;

        public Member Member
        {
            get { return member; }
            set { member = value; }
        }

       public object Clone()
        {
            ConcretePrototypeB copy = (ConcretePrototypeB)this.MemberwiseClone();
            Member newmember = new Member();
            copy.member = newmember;
            return copy;
        }
    }
}
