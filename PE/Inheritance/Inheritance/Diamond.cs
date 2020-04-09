using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// Diamond enemy type
    /// </summary>
    
    class Diamond : Enemy
    {
        // fields
        public bool chasesYou = true;

        // properties
        public bool ChasesYou
        {
            get { return chasesYou; }
        }

        // constructor
        public Diamond() : base()
        {
            color = "blue";
            shape = "diamond";
            speed = 9;
        }
    }
}
