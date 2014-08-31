using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class CarGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get { return "Window glassware for a car"; }
        }
    }
}
