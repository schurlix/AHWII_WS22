﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;
class TicketautomatFIE : Ticketautomat
{
    public String Standort { get; set; }
    public int ticketpreis { get; set; }
    public int eingeworfen { get; }

    public int gesamtEinnahmen { get; }
    public TicketautomatFIE(String Standort, int ticketPreis)
    {
        this.Standort = Standort;
        this.ticketpreis = ticketPreis;
        this.eingeworfen = 0;
        this.gesamtEinnahmen = 0;
    }
    public override string ToString()
    {
        return $"Ich bin ein Ticketautomat GRAFG, stehe in {this.Standort}, jedes Ticket kostet bei mir {ticketpreis}€.";
    }

    public void einwerfen(int betrag)
    {

    }
   
    // Hello World
    bool ticketDrucken()
    {
        return false;
    }
    int wechselGeldAuszahlen()
    { return 0; }
}
