
using System;

namespace automat;

class Program
{
    static void Main(string[] args)
    {
        Ticketautomat[] automaten = {
            new TicketautomatGRAFG("Westbahnhof", 3),

        };
        foreach (var tick in automaten)
        {
            Console.WriteLine(tick);
        }
    }
}
