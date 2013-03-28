using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GumballMachine
{
    class GumballMachine
    {
        IState SOLD_OUT;
        IState NO_QUARTER;
        IState HAS_QUARTER;
        IState SOLD;

        IState state;
        int count = 0;

        public GumballMachine(int count)
        {
            SOLD_OUT = new SoldOutState(this);
            NO_QUARTER = new NoQuarterState(this);
            HAS_QUARTER = new HasQuarterState(this);
            SOLD = new SoldState(this);

            state = SOLD_OUT;

            this.count = count;
            if (this.count > 0) state = NO_QUARTER;            
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        //public void Dispense()
        //{
        //    if (state == SOLD)
        //    {
        //        Console.WriteLine("A gumbal comes rolling out the slot");
        //        count--;
        //        if (count == 0)
        //        {
        //            Console.WriteLine("Opps, out of gumball");
        //            state = SOLD_OUT;
        //        }
        //        else
        //        {
        //            state = NO_QUARTER;
        //        }
        //    }
        //    else if (state == NO_QUARTER)
        //    {
        //        Console.WriteLine("You need to pay first");
        //    }
        //    else if (state == SOLD_OUT)
        //    {
        //        Console.WriteLine("No gumball dispensed");
        //    }
        //    else if (state == HAS_QUARTER)
        //    {
        //        Console.WriteLine("No gumball dispensed");
        //    }
        //}

        public void Refill(int count)
        {
            this.count += count;
            if (this.count > 0) state = NO_QUARTER;
            else state = SOLD_OUT;
        }

        public override string ToString()
        {
            string wording = "Inventory : " + this.count.ToString();
            string stateStr = state.GetType().ToString();

            //switch (state)
            //{
            //    case SOLD_OUT: stateStr = "Machine is sold out"; break;
            //    case NO_QUARTER: stateStr = "Machine is waiting for quarter"; break;
            //    case HAS_QUARTER: stateStr="Machine is waiting to crank";break;
            //    case SOLD: stateStr = "Machine is rolling out a gumball"; break;
            //    default: break;
            //}

            wording += "\n" + stateStr;

            return wording;
        }

        public IState GetHasQuarterState()
        {
            throw new NotImplementedException();
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count--;
            }
        }
    }
}
