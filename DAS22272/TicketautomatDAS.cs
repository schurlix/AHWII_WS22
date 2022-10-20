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

    public int eingeworfen { get; private set; }

    public int gesamteinnahmen { get; }
    public bool betragErreicht { get; }
    public TicketautomatDAS(String Standort, int ticketPreis)
    {
        this.Standort = Standort;
        this.ticketpreis = ticketPreis;
        this.eingeworfen = 0;
        this.gesamteinnahmen = 0;
    }
    public override string ToString()
    {
        return $"Ich bin ein Ticketautomat DAS22272, stehe in {this.Standort}, jedes Ticket kostet bei mir {ticketpreis}€.";

        if (ticketDrucken == true)
        {
            return $"Ihr Ticket wird Gedruckt";
        }
    }

    public void einwerfen(int betrag)
    {  
    this.eingeworfen += betrag
        if (this.eingeworfen >= this.ticketpreis )
        {
           betragErreicht = true;
        }
            
    }

    bool ticketDrucken() 
    {
        if (betragErreicht == true && ticketDrucken == false ) 
        {
        return true;
        }
        return false;
    }

    
   
    
    int wechselGeldAuszahlen()
    {
        if (this.eingeworfen > this.ticketpreis)
        {
            int a = this.eingeworfen - this.ticketpreis;
            return a;
        }
        return 0; 
    }



}

