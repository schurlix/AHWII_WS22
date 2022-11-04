
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
            new TicketautomatCHA("Pilgramgasse", 3),
        };
        foreach (var tick in automaten)
        {
            // Teste einwerfen und Wechselgeld
            if (!testeEinwerfenWechselgeld(tick))
            {
                Console.WriteLine($"ERROR: {tick.GetType()} macht Fehler beim Einwerfen oder Wechselgeld.");

            }
        }
        // Situation: in jedem automaten ist Geld und eingerworfen stimmt 
        // Test: soviele Tickets drucken wie möglich
        // nächstes Mal drucken soll Fehler liefern
        // gesamtEinnahmen sollen stimmen
        // eingeworfen soll stimmen

        foreach (var tick in automaten)
        {
            int druckbar = tick.eingeworfen / tick.ticketPreis;
            int sollEingeworfen = tick.eingeworfen % tick.ticketPreis;
            // TEST: sollte druckbar mal erfolgreich sein
            for (int i = 0; i < druckbar; i++)
            {
                if (!tick.ticketDrucken()) // das wäre falsch
                {
                    Console.WriteLine($"ERROR: {tick.GetType()} druckt nicht genügend tickets");
                }
            }

            // zustand sollte sein: eingeworfen ist weniger als ticketpreis
            if (tick.ticketDrucken())
            {
                Console.WriteLine($"ERROR: {tick.GetType()} druckt tickets obwohl zu wenig Geld da ist");
            }

            // zustand: gesamt = druckbar * Ticketpreis
            if (!(tick.gesamtEinnahmen == druckbar * tick.ticketPreis))
            {
                Console.WriteLine($"ERROR: {tick.GetType()} Gesamt. Soll: {druckbar*tick.ticketPreis}, Ist: {tick.gesamtEinnahmen}");
            }

            // eingeworfen: sollEingeworfen 
            if (!(tick.eingeworfen == sollEingeworfen))
            {
                Console.WriteLine($"ERROR: {tick.GetType()} Eingeworfen. Soll: {sollEingeworfen}, Ist: {tick.eingeworfen}");
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