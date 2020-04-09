using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// Parent class for all enemy types
    /// </summary>
    
    class Enemy
    {
        // fields
        protected string color;
        protected string shape;
        protected int speed;

        // properties
        public string Color
        {
            get { return color; }
        }

        public string Shape
        {
            get { return shape; }
        }

        public int Speed
        {
            get { return speed; }
        }

        // constructor
        public Enemy()
        {
            this.color = "unknown";
            this.shape = "unknown";
            this.speed = 0;
        }

        /// <summary>
        /// Prints information about enemy to console.
        /// </summary>
        // method
        public void Print()
        {
            Console.WriteLine(
                "Color: {0}\n" +
                "Shape: {1}\n" +
                "Speed: {2}",
                color, shape, speed);
        }
    }
}
