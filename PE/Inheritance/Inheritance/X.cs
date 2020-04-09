using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// X enemy type
    /// </summary>
    
    class X : Enemy
    {
        // fields
        public int splitsInto = 2;

        // properties
        public int SplitsInto
        {
            get { return splitsInto; }
        }

        // constructor
        public X() : base()
        {
            color = "pink";
            shape = "X";
            speed = 5;
        }
    }
}
