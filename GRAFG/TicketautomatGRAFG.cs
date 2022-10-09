using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;    
class TicketautomatGRAFG
{
    private String Standort { get; set; }
    private int ticketpreis;
    public TicketautomatGRAFG(String Standort, int ticketPreis)
    {
        this.Standort = Standort;
        this.ticketpreis = ticketPreis;
    }
    public override string ToString()
    {
        return $"Ich bin ein Ticketautomat GRAFG, stehe in {this.Standort}, jedes Ticket kostet bei mir {ticketpreis} €.";
    }
}

