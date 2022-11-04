using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;
public interface Ticketautomat
{
    //public String? standort;
    int ticketPreis { get; set; }
    int eingeworfen { get; }
     int gesamtEinnahmen { get; }

    void einwerfen(int a);


     bool ticketDrucken();
    public int wechselGeldAuszahlen() {
        return 0;
    }

    public void print() { }

}

