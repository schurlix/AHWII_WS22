using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;
class TicketautomatHAS : Ticketautomat
{
    public String Standort { get; set; }
    public int gesamtEinnahmen { get; private set; }
    public TicketautomatHAS(String Standort, int ticketPreis)
    {
        this.Standort = Standort;
        this.ticketPreis = ticketPreis;
        this.eingeworfen = 0;
        this.gesamtEinnahmen = 0;
        
    }
    public override string ToString()
    {
        return $"Ich bin ein Ticketautomat HAS, stehe in {this.Standort}, jedes Ticket kostet bei mir {ticketPreis}€.";
    }
    
    public void einwerfen(int betrag)
    {
       
        this.eingeworfen += betrag;

       

    }

    bool ticketDrucken()
    {
        if (this.ticketpreis > this.eingeworfen)
        {
            Console.WriteLine($"Es fehlen noch  {this.ticketpreis - this.eingeworfen} Euro");
            return false;
        }
        this.eingeworfen -= this.ticketpreis;
        this.gesamtEinnahmen += this.ticketpreis;
        Console.WriteLine("#######################################");
        Console.WriteLine("");
        Console.WriteLine("Fahrschein");
        Console.WriteLine("         Standort: " + this.Standort);
        Console.WriteLine("         Preis: " + this.ticketpreis);
        Console.WriteLine("");
        Console.WriteLine("#######################################");
        return true;

    }
    int wechselGeldAuszahlen()
    {
        int eingeworfenAuszahlen = eingeworfen;
        eingeworfen = 0;
        return eingeworfenAuszahlen;
           
    }
}



