using automat;

namespace automat
{
    static class Programm
    {
        private static void Main(string[] args)
        {
            Ticketautomat[] automaten = {
            new TicketautomatGRAFG("Westbahnhof", 3),

        };
            foreach (var tick in automaten)
            {
                Console.WriteLine(tick);
            }
        }
    }
}