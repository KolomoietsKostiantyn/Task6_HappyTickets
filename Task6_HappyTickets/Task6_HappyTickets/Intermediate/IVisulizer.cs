using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_HappyTickets.Intermediate
{
    interface IVisualizer
    {
        void SendMasage(Messages mes);
        void SendAnswer(ScryptType type, int Occurrences, int number);
    }
}
