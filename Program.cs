
namespace automat;

class Program
{
    static void Main(string[] args)
    {
        Ticketautomat[] automaten = {
            new TicketautomatGRAFG("Westbahnhof", 3),
            new TicketautomatDAS("Matzleinsdorfer Platz", 5),
            new TicketautomatASC("Hütteldorf", 7),
            new TicketautomatFIE("Spengergasse", 2),
            new TicketautomatHAS("Heiligenstadt", 3),
            new TicketautomatCHA("Heiligenstadt", 3),
        };
        foreach (var tick in automaten)
        {
            testedenautmaten(tick);
        }

    }
    static bool testedenautmaten(Ticketautomat tick)
    {
        tick.einwerfen(3);
        Console.WriteLine(tick);
        return false;
    }
   

}