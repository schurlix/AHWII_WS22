
﻿using System;

namespace automat;

class Program
{
    static void Main(string[] args)
    {
        //Ticketautomat tick = new Ticketautomat("Westbahnhof", 3);
        var tick = new TicketautomatGRAFG();
        Console.WriteLine(tick);
        Thread.Sleep(1000);
        Console.WriteLine("Hallo!");
        Thread.Sleep(1000);
    }
}
