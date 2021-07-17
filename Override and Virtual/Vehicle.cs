using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_and_Virtual
{
    class Vehicle
    {
        #region fields

        public int numOfWheels;
        public string color;
        public bool isRoofOpen;

        #endregion

        #region constructors

        public Vehicle()
        {

        }

        public Vehicle(int numOfWheels, string color, bool isRoofOpen)
        {
            this.numOfWheels = numOfWheels;
            this.color = color;
            this.isRoofOpen = isRoofOpen;
        }

        #endregion

        #region methods

        public virtual void AddWheel()
        {
            if (numOfWheels < 4)
            {
                numOfWheels++;
            }
            Console.WriteLine($"Current numOfWheels: {numOfWheels}");
        }

        public void OpenOrCloseRoof()
        {
            isRoofOpen = !isRoofOpen;
        }

        #endregion
    }
}
