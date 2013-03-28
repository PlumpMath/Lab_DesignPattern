using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GumballMachine
{
    class SoldState : IState
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            // TODO: Complete member initialization
            this.gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }
    }
}
