using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class GeneralEnquiresEmailHandler:AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[0]; // match anything
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Email handled by general enquiries.");
        }
    }
}
