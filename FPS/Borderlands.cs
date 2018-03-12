using GameInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPS
{
    [Description("Klasa, która oblicza czy gra Borderlands zadziała na komputerze, który ma parametry jak podane dane wejściowe (processor (GHz), RAM (GB), graphic(GB))")]
    class Borderlands : IGame 
    {
        public bool Requirements(double processor, int RAM, int graphic)
        {
            if (processor > 1 && RAM >= 3 && graphic >= 1024)
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
