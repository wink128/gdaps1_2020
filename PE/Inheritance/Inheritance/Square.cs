using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// Square enemy type
    /// </summary>

    class Square : Enemy
    {
        // fields
        public bool isScared = true;

        // properties
        public bool IsScared
        {
            get { return isScared; }
        }

        // constructor
        public Square() : base()
        {
            color = "green";
            shape = "square";
            speed = 12;
        }
    }
}
