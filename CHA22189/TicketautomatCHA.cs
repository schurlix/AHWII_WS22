using automat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;    
class TicketautomatCHA : Ticketautomat
{
    public String standort { get; set; }
    public int ticketpreis { get; set; }
    public int eingeworfen { get; set; }

    public int gesamtEinnahmen { get; }


    public TicketautomatCHA(String standort, int ticketPreis)
    {
        this.standort = standort;
        this.ticketpreis = ticketPreis;
        this.eingeworfen = 0;
        this.gesamtEinnahmen = 0;

        
    }
    public override string ToString()
    {
        return $"Ich bin ein Ticketautomat, stehe in {this.standort}, jedes Ticket kostet bei mir {ticketpreis}€. Bitte werfen sie { ticketpreis} ein, um ein Ticket für {standort} zu kaufen.";
    }
     
    public void einwerfen()
    {
        
        Console.WriteLine($"Bitte werfen Sie für das Ticket {ticketpreis-eingeworfen} Euro ein." );

        int betrag = Convert.ToInt32(Console.ReadLine());
        eingeworfen = eingeworfen + betrag;
        ticketDrucken();
        
    }

    void ticketDrucken()
    {
        if (eingeworfen < ticketpreis)
        {
            Console.WriteLine($"Du hast {eingeworfen} eingeworfen. Leider ist das zu wenig. Bitte werfe noch folgenden Betrag ein:" + (ticketpreis - eingeworfen));
            einwerfen();
        }
        else
        {
            Console.WriteLine("#######################################");
            Console.WriteLine("");
            Console.WriteLine("Fahrschein");
            Console.WriteLine("         Standort: " + this.standort);
            Console.WriteLine("         Preis: " + this.ticketpreis);
            Console.WriteLine("");
            Console.WriteLine("#######################################");
        }
       
    }
    

}

