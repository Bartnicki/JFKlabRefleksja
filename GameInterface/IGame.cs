using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterface
{
    public interface IGame
    {
        bool Requirements(double processor, int RAM, int graphic);
  
    }
}