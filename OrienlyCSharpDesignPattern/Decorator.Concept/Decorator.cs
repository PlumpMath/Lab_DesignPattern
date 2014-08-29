using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Concept
{
    class Decorator : IComponent
    {
        object addedState { get; set; }
        IComponent component { get; set; }

        public Decorator(IComponent baseComponent) { }
        public void Operation()
        {
            throw new NotImplementedException();
        }

        public void AddedBehavior()
        {
        }
    }
}
