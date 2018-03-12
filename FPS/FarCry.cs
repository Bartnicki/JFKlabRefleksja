using GameInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPS
{
    [Description("Klasa, która oblicza czy gra FarCry zadziała na komputerze, który ma parametry jak podane dane wejściowe (processor (GHz), RAM (GB), graphic(GB))")]
    class FarCry : IGame
    {
        public bool Requirements(double processor, int RAM, int graphic)
        {
            if (processor > 1.5 && RAM >= 4 && graphic >= 1024)
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
