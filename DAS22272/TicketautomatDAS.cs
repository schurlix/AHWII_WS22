using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;    
class TicketautomatDAS : Ticketautomat
{
    public String Standort { get; set; }
    public int ticketPreis { get; set; }

    public int eingeworfen { get; private set; }

    public int gesamtEinnahmen { get; }
    //DAS_is_the_best


    public TicketautomatDAS(String Standort, int ticketPreis)
    {
        this.Standort = Standort;
        this.ticketPreis = ticketPreis;
        this.eingeworfen = 0;
        this.gesamtEinnahmen = 0;

    }
    public override string ToString()
    {
        string e = $"Das Hier ist der Ticketautomat DAS22272, er steht am {this.Standort}. Jedes Ticket kostet beim Ticketautomat DAS22272 nur {ticketPreis}€. Mit diesem Ticket können Sie in die S-Bahn bei {this.Standort} einsteigen und innerhalb von Wien einmal fahren. Das Ticktet wird sofortig entwertet und ist nicht mehrmals Gültig. Wenn Sie eine Tageskarte kaufen wollen fahren Sie bitte zum Hauptbahnhof. Wenn Sie eine Wochenkarte kaufen wollen fahren Sie bitte zum Hauptbahnhof. Wenn Sie eine Monatskarte kaufen wollen fahren Sie bitte zum Hauptbahnhof. Wenn Sie eine Jahreskarte kaufen wollen fahren Sie bitte zum Hauptbahnhof. Bitte werfen Sie nun {{ticketPreis}}€ ein oder verlassen Sie die Station. Wenn der Betrag nicht gezahlt wird muss die Polizei gerufen werden\n";
        /*$"Das Hier ist der Ticketautomat DAS22272, er steht am {this.Standort}";
        $"jedes Ticket kostet beim Ticketautomat DAS22272 nur {ticketPreis}€.";
        $"Mit diesem Ticket können Sie in die S-Bahn bei {this.Standort} einsteigen und innerhalb von Wien einmal fahren.";
        $"Das Ticktet wird sofortig entwertet und ist nicht mehrmals Gültig";
        $"Wenn Sie eine Tageskarte kaufen wollen fahren Sie bitte zum Hauptbahnhof";
        $"Wenn Sie eine Wochenkarte kaufen wollen fahren Sie bitte zum Hauptbahnhof";
        $"Wenn Sie eine Monatskarte kaufen wollen fahren Sie bitte zum Hauptbahnhof";
        $"Wenn Sie eine Jahreskarte kaufen wollen fahren Sie bitte zum Hauptbahnhof";
        $"Bitte werfen Sie nun {ticketPreis}€ ein oder verlassen Sie die Station";
        $"Wenn der Betrag nicht gezahlt wird muss die Polizei gerufen werden";*/
        return e;
    }

    public void einwerfen(int betrag)
    {
        this.eingeworfen += betrag;
      /*  if (this.eingeworfen >= this.ticketPreis )
        {
           betragErreicht = true;
        }
            */
    }

    public bool ticketDrucken() 
    {
        if (eingeworfen >= ticketPreis) 
        {
            this.eingeworfen = this.eingeworfen - this.ticketPreis;
            // Console.WriteLine($"Ticket vom {this.Standort}");
            return true;
        }
        return false;
    }

    
   
    
    int wechselGeldAuszahlen()
    {
        if (ticketDrucken() == true)
        {
            int a = this.eingeworfen;
            return a;
        }
        else if (this.eingeworfen < this.ticketPreis)
        {
            int b = this.eingeworfen;
            return b;
        }
        return 0;
    }



}

