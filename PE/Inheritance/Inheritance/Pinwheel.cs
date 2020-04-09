using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// Pinwheel enemy type
    /// </summary>
    
    class Pinwheel : Enemy
    {
        // fields
        public bool canBounce = true;

        // properties
        public bool CanBounce
        {
            get { return canBounce; }
        }

        // constructor
        public Pinwheel() : base()
        {
            color = "purple";
            shape = "pinwheel";
            speed = 7;
        }
    }
}
