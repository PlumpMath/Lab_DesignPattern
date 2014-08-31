using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class VanGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get { return "Window glassware for a van"; }
        }
    }
}
