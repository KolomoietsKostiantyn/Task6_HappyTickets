using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.Intermediate;

namespace Task6_HappyTickets.UI
{
    

    class ConsoleUI : IVisualizer
    {
        string instruction = "Enter the path to the document where the type of the algorithm and " +
                "the ticket number are indicated(when the program is started)";

        public void SendAnswer(ScryptType type, int Occurrences, int number)
        {
            Console.WriteLine(string.Format("Before {0} exist {1} happy tickets by {2} script", number, Occurrences, type));
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
                    Console.WriteLine("This file does not exist or cannot be opened");
                    break;
                case Messages.IncorectContext:
                    Console.WriteLine("File content does not match '<script name> <ticket>'");
                    break;
                case Messages.IncorectScript:
                    Console.WriteLine("The script with the same name does not exist.");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
