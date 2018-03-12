using GameInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPS
{
    [Description("Klasa, która oblicza czy gra CounterStrike zadziała na komputerze, który ma parametry jak podane dane wejściowe (processor (GHz), RAM (GB), graphic(GB))")]
    class CounterStrike : IGame
    {
        public bool Requirements(double processor, int RAM, int graphic)
        {
            if (processor > 2.5 && RAM >= 8 && graphic >= 2048)
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
