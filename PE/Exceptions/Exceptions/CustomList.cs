using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// A custom list
    /// </summary>
    class CustomList
    {
        // fields
        public int count;
        public string[] data;

        // constructors
        public CustomList()
        {
            data = new string[4];
            count = 0;
        }

        public CustomList(int arraySize)
        {
            if (arraySize < 0)
            {
                throw new System.ArgumentException("Error creating list! \n" +
                    "Non-negative number required. Parameter name: capacity."); 
            }
            else
            {
                data = new string[arraySize];
                count = 0;
            }
            
        }

        // methods
        /// <summary>
        /// adds an element to the list
        /// </summary>
        /// <param name="item"></param>
        public void Add(string item)
        {
            while (count < data.Length)
            {
                if (data[count] != null)
                {
                    count++;
                }
                else
                {
                    data[count] = item;
                    break;
                }
            }
            
            
        }

        /// <summary>
        /// writes element at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetElement(int index)
        {
            if (index < 0 || index > data.Length || data[index] == null)
            {
                throw new System.IndexOutOfRangeException("Error! Stopping all code in TRY.");
            }
            else
            {
                return data[index];
            }
        }
    }
}
