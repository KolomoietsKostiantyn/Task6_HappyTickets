using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.BL;
using Task6_HappyTickets.Intermediate;
using Task6_HappyTickets.UI;

namespace Task6_HappyTickets
{
    class Program
    {
        static void Main(string[] args)
        {

            IVisualizer visualizer = new ConsoleUI();
            IInnerDataParser innerDataParser = new InnerDataParser();
            IScriptSelecter scriptSelecter = new ScriptSelecter();
            IScriptReader serviceProvider = new FileSystemReader();

            Controler controler = new Controler(visualizer, innerDataParser, scriptSelecter, serviceProvider, args);
            controler.Start();



        }
    }
}
