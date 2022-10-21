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
        string e = $"Das Hier ist der Ticketautomat DAS22272, er steht am {this.Standort}. Jedes Ticket kostet beim Ticketautomat DAS22272 nur {ticketPreis}€. Mit diesem Ticket können Sie in die S-Bahn bei {this.Standort} einsteigen und innerhalb von Wien einmal fahren. Das Ticktet wird sofortig entwertet und ist nicht mehrmals Gültig. Wenn Sie eine Tageskarte kaufen wollen fahren Sie bitte zum Hauptbahnhof. Wenn Sie eine Wochenkarte kaufen wollen fahren Sie bitte zum Hauptbahnhof. Wenn Sie eine Monatskarte kaufen wollen fahren Sie bitte zum Hauptbahnhof. Wenn Sie eine Jahreskarte kaufen wollen fahren Sie bitte zum Hauptbahnhof. Bitte werfen Sie nun {{ticketPreis}}€ ein oder verlassen Sie die Station. Wenn der Betrag nicht gezahlt wird muss die Polizei gerufen werden\";"
         
       return e;

        if (ticketDrucken == true)
        {
            return $"Ihr Ticket wird Gedruckt";
        }
        if (this.eingeworfen < this.ticketpreis)
        {
            string f = $"Nicht genug Geld. Wollen Sie etwa Schwarzfahren? Sie bekommen Ihr Geld zurück. Sie können es nochmal versuchen"
            
            return f;

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
        this.eingeworfen = this.eingeworfen - this.ticketpreis;
        return true;
        }
        return false;
    }

    
   
    
    int wechselGeldAuszahlen()
    {
        if (ticketDrucken == true)
        {
            int a = this.eingeworfen;
            return a;
        }
        else if (this.eingeworfen < this.ticketpreis)
        {
            int b = this.eingeworfen;
            return b;
        }
         
    }

    int gesamteinnahmen ()
    {
        if (ticketDrucken == true)
        {
            gesamteinnahmen += this.ticketpreis;
        }
    }



}

