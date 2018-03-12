using GameInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    [Description("Klasa, która oblicza czy gra WOW zadziała na komputerze, który ma parametry jak podane dane wejściowe (processor (GHz), RAM (GB), graphic(GB))")]
    class WOW : IGame
    {
        public bool Requirements(double processor, int RAM, int graphic)
        {
            if (processor > 1.2 && RAM >= 2 && graphic >= 512)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
