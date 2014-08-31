using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SalesEmailHandler:AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "buy", "purchase" };
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Email handled by sales department.");
        }
    }
}
