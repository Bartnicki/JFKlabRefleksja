using GameInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    [Description("Klasa, która oblicza czy gra Fallout zadziała na komputerze, który ma parametry jak podane dane wejściowe (processor (GHz), RAM (GB), graphic(GB))")]
    class Fallout : IGame
    {
        public bool Requirements(double processor, int RAM, int graphic)
        {
            if (processor > 3.0 && RAM >= 12 && graphic >= 2048)
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
