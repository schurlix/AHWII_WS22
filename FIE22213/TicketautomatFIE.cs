using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;
class TicketautomatFIE : Ticketautomat
{
    public String Standort { get; set; }
    public int ticketPreis { get; set; }
    public int eingeworfen { get; private set; }
    public int gesamtEinnahmen { get; }

    public TicketautomatFIE(String Standort, int ticketPreis)
    {
        this.Standort = Standort;
        this.ticketPreis = ticketPreis;
        this.eingeworfen = 0;
        this.gesamtEinnahmen = 0;
    }
    public override string ToString()
    {
        return $"Ich bin ein Ticketautomat FIE, stehe in {this.Standort}, jedes Ticket kostet bei mir {ticketPreis}€.";
    }

    public void einwerfen(int betrag)
    {
        this.eingeworfen += betrag;
    }
   
    
    bool ticketDrucken()
    {
        if (eingeworfen >= ticketpreis)
        { 
                    Console.WriteLine($"################");
                    Console.WriteLine($"FAHRSCHEINStandort: {Standort}");
                    Console.WriteLine($"Gute Fahrt!");
                    Console.WriteLine($"################");

            return true;
        }
        else
        {
            Console.WriteLine($"Zu wenig Geld. Null Punkte")
            return false;
        }
    }

    int wechselGeldAuszahlen(int wechselGeld)
    { 
        if(ticketDrucken() = true)
        {
            wechselGeld = eingeworfen
            eingeworfen = 0
            return wechselGeld;
        }
    }

    int GesamtEinnahmen(int GesamtEinnahmen)
    {
        if (ticketDrucken() = true)
        {
            GesamtEinnahmen = GesamtEinnahmen + ticketpreis;
            return GesamtEinnahmen;
        }
    }
}
