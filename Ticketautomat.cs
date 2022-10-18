using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat;
public interface Ticketautomat
{
    //public String? standort;
    public int ticketPreis { set; get; }
    public int eingeworfen { get; }
    public int gesamtEinnahmen { get; }

    public void einwerfen(int a) { }

    public bool ticketDrucken() {
        return false;
    }
    public int wechselGeldAuszahlen() {
        return 0;
    }

    public void print() { }

}

