using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class VanChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get { return "Chassis parts for a van"; }
        }
    }
}
