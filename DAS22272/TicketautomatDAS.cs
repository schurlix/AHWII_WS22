using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;    
class TicketautomatDAS : Ticketautomat
{
    public String Standort { get; set; }
    public int ticketpreis { get; set; }

    public int eingeworfen { get; }

    public int gesamteinnahmen { get; }
    public TicketautomatDAS(String Standort, int ticketPreis)
    {
        this.Standort = Standort;
        this.ticketpreis = ticketPreis;
        this.eingeworfen = 0;
        this.gesamteinnahmen = 0;
    }
    public override string ToString()
    {
        return $"Ich bin ein Ticketautomat DAS22272, stehe in {this.Standort}, jedes Ticket kostet bei mir {ticketpreis}Euro.";
    }

    public void einwerfen(int betrag)
    {    }
    bool ticketDrucken() {
        return false;
    }
    
    int wechselGeldAuszahlen() { return 0; }



}

