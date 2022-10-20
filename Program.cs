using System;

namespace automat;

class Program
{
    static void Main(string[] args)
    {
        TicketautomatCHA automaten = new TicketautomatCHA("Geistigestadt",6);
        Console.WriteLine(automaten.ToString());
        automaten.einwerfen();
        Console.ReadLine();

    }
   

}