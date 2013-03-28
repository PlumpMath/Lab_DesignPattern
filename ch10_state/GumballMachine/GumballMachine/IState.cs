using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GumballMachine
{
    interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
