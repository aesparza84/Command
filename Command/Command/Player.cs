using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Player
    {
        public int LocationX;
        public int LocationY;

        public Player()
        {
            this.LocationX = 0;
            this.LocationY = 0;
        }

        public string ReturnLocation() 
        {
            return $"Location X:{LocationX} Y{LocationY}";
        }
    }
}
