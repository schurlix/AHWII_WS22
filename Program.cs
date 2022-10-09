
﻿using System;

namespace automat;

class Program
{
    static void Main(string[] args)
    {
        //Ticketautomat tick = new Ticketautomat("Westbahnhof", 3);
        var tick = new TicketautomatGRAFG("Westbahnhof", 3);
        Console.WriteLine(tick);
    }
}
