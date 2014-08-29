using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Concept
{
    class DecoratorB : IComponent
    {
        IComponent component { get; set; }
        public void Operation()
        {
            throw new NotImplementedException();
        }
    }
}
