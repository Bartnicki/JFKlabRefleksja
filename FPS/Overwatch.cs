using GameInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPS
{
    [Description("Klasa, która oblicza czy gra Overwatch zadziała na komputerze, który ma parametry jak podane dane wejściowe (processor (GHz), RAM (GB), graphic(GB))")]
    class Overwatch : IGame
    {
        public bool Requirements(double processor, int RAM, int graphic)
        {
            if (processor > 2.8 && RAM >= 4 && graphic >= 1024)
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
