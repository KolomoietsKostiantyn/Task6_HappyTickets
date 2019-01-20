using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.BL;
using Task6_HappyTickets.Intermidiate;
using Task6_HappyTickets.UI;

namespace Task6_HappyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisulizer visulizer = new ConsoleUI();
            Controler cntrl = new Controler(visulizer, args);
            cntrl.Start();
        }
    }
}
