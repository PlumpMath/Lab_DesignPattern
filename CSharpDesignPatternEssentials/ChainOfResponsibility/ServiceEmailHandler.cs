using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ServiceEmailHandler:AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "service", "repair" };
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Email handled by service department.");
        }
    }
}
