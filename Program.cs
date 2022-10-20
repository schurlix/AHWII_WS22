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


        //TicketautomatCHA[] automaten = {
        //    new TicketautomatCHA("Geistigestadt", 6),
        //};
        //foreach (var tick in automaten)
        //{
        //    testedenautmaten(tick);
        //}

    }
    //static bool testedenautmaten(TicketautomatCHA tick)
    //{
    //    //tick.einwerfen(3);
    //    //Console.WriteLine(tick);
    //    //return false;
    //}

}