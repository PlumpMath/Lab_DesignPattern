using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Concept
{
    class Client
    {
        Component Component { get; set; }
        Decorator Decorator { get; set; }

        public void Test()
        {
            Component photo = new Component();
            Decorator foodTag = new Decorator(photo);
            Decorator colorTag = new Decorator(foodTag);

        }
    }
}
