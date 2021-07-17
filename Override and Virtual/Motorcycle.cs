using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_and_Virtual
{
    class Motorcycle : Vehicle
    {
        #region methods

        public override void AddWheel()
        {
            if (numOfWheels < 2)
            {
                numOfWheels++;
            }
            Console.WriteLine($"Current numOfWheels: {numOfWheels}");
        }

        new public void OpenOrCloseRoof()
        {
            Console.WriteLine("On a motorcycle, the roof is always open");
        }

        #endregion
    }
}
