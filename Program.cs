
﻿using System;

namespace automat;

class Program
{
    static void Main(string[] args)
    {
        //Ticketautomat tick = new Ticketautomat("Westbahnhof", 3);
        var tick = new TicketautomatGRAFG("Westbahnhof", 3);
        var tick1 = new TicketautomatDAS("Matzleinsdorfer Platz", 5);
        Console.WriteLine(tick);
        Console.WriteLine(tick1);
    }
}
