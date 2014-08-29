using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Concept
{
    class DecoratorA:IComponent
    {
        IComponent component { get; set; }
        public void Operation()
        {
            throw new NotImplementedException();
        }
    }
}
