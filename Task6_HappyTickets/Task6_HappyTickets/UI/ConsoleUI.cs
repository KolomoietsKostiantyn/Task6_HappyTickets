using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.Intermidiate;

namespace Task6_HappyTickets.UI
{
    class ConsoleUI : IVisulizer
    {
        private string instruction = "alternately enter the path to the file where the algorithm" +
                " is specified, and then the number and get the number of happy" +
                "tickets for the specified method of counting";

        public string AskNunber()
        {
            Console.WriteLine("Enter a number in the range of 1 - 999999");
            return Console.ReadLine();
        }

        public string AskPath()
        {
            Console.WriteLine("Enter the path to the file with the algorithm");
            return Console.ReadLine();
        }

        public void SendAnswer(ScryptType type, int count)
        {
            string result = "For the algorithm {0} exists {1} happy tickets.";
            Console.WriteLine(string.Format(result, type, count));
            Console.ReadKey();
        }

        public void SendMasage(Messages mes)
        {
            switch (mes)
            {
                case Messages.Instruction:
                    Console.WriteLine(instruction);
                    break;
                case Messages.WrongPath:
                    Console.WriteLine("Such file does not exist or the name of the algorithm is not specified.");
                    break;
                case Messages.IncorectNumber:
                    Console.WriteLine("Cannot convert this to a number between 1 and 999999");
                    break;
                default:
                    break;
            }
        }
    }
}
