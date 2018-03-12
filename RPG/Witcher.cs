using GameInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    [Description("Klasa, która oblicza czy gra Witcher zadziała na komputerze, który ma parametry jak podane dane wejściowe (processor (GHz), RAM (GB), graphic(GB))")]
    class Witcher : IGame
    {
        public bool Requirements(double processor, int RAM, int graphic)
        {
            if (processor > 2.5 && RAM >= 16 && graphic > 4096)
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
