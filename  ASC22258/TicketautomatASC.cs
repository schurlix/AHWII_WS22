using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;    
class TicketautomatASC : Ticketautomat
{
    public String Standort { get; set; }
    public int ticketPreis { get; set; }
    public int eingeworfen { get; private set; }

    public int gesamtEinnahmen { get; }
    public TicketautomatASC(String Standort, int ticketPreis)
    {
        this.Standort = Standort;
        this.ticketPreis = ticketPreis;
        this.eingeworfen = 0;
        this.gesamtEinnahmen = 0;
    }
    public override string ToString()
    {
        return $"Ich bin ein Ticketautomat ASC22256, stehe in {this.Standort}, jedes Ticket kostet bei mir {ticketPreis}€.";
    }
     
    public void einwerfen(int betrag)
    {
        eingeworfen += betrag;

    }

    public bool ticketDrucken()
    {
        return false;
    }
    int wechselGeldAuszahlen()
    { return 0; }
}

