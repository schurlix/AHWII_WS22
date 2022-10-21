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
    public int gesamtEinnahmen { get; private set; }

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
   
    
    public bool ticketDrucken()
    {
        if (eingeworfen >= ticketPreis)
        {
            gesamtEinnahmen += ticketPreis;
            eingeworfen -= ticketPreis;
                    Console.WriteLine($"################");
                    Console.WriteLine($"FAHRSCHEINStandort: {Standort}");
                    Console.WriteLine($"Gute Fahrt!");
                    Console.WriteLine($"################");

            return true;
        }
        else
        {
            Console.WriteLine($"Zu wenig Geld. Null Punkte");
            return false;
        }
    }

    public int wechselGeldAuszahlen()
    {
        int reture = eingeworfen;
        eingeworfen = 0;
        return reture;
    }

 }
