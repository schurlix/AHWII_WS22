
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
            testedenautmaten(tick);
        }

    }
    static bool testedenautmaten(Ticketautomat tick)
    {
        tick.einwerfen(3);
        return false;
    }

}
