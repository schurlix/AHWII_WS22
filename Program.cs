
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
            // Teste einwerfen und Wechselgeld
            if (!testeEinwerfenWechselgeld(tick))
            {
                Console.WriteLine($"ERROR: {tick.GetType()} macht Fehler beim Einwerfen oder Wechselgeld.");

            }
        }

    }
    static bool testeEinwerfenWechselgeld(Ticketautomat tick)
    {
        var gen = new Random();
        int jetzt, gesamt = 0;
        int wieoft = gen.Next(2, 12);
        for (int i = 0; i < wieoft; i++)
        {
            jetzt = gen.Next(10);
            gesamt += jetzt;
            tick.einwerfen(jetzt);
        }
        // Console.WriteLine($"gesamt: {gesamt}, tick: {tick.eingeworfen}");
        if (tick.eingeworfen == gesamt)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}