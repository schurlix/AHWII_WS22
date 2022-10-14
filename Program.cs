
﻿using System;

namespace automat;

class Program
{
    static void Main(string[] args)
    {
        Ticketautomat[] automaten = {
            new TicketautomatGRAFG("Westbahnhof", 3),
            new TicketautomatDAS("Matzleinsdorfer Platz", 5)

        };
        foreach (var tick in automaten)
        {
            Console.WriteLine(tick);
        }
    }
}
