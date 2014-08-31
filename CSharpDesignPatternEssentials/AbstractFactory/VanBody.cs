using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VanBody:IBody
    {
        public virtual string BodyParts
        {
            get { return "Body shell parts for a van"; }
        }
    }
}
