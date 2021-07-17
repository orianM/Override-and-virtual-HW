using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_and_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*a.Virtual - means a method can be overridden, if you want to make a method that can be overridden
                you need to declare virtual in the method signature.

              b.Override - is used to change the base ability of a virtual method.

              c.New - can be used to create a new ability in the child classes for a method of the parent class, 
                even if not declared as virtual.
                for example if we create a method: public void PrintSomething()
                                                   {
                                                        Console.WriteLine("Something");
                                                   }

                 even though we didn't declare the method as virtual we can allocate a place in the memory for a different class.
                 like this:
                                                   new public void PrintSomething()
                                                   {
                                                        Console.WriteLine("Not something");
                                                   }*/


            #endregion

            #region question 2

            /*real life example of base class and inheritance class: 
              ATM - when you go to the bank to withdraw or deposit money in the atm
              for example(base class ability is withdraw, inherited class ability is deposit.)*/

            #endregion

            #region question 3

            Vehicle onlyBase = new Vehicle();
            onlyBase.AddWheel();
            onlyBase.OpenOrCloseRoof();

            Vehicle baseWithCar = new Car();
            baseWithCar.AddWheel();
            baseWithCar.OpenOrCloseRoof();

            Vehicle baseWithMotorcycle = new Motorcycle();
            baseWithMotorcycle.AddWheel();
            baseWithMotorcycle.OpenOrCloseRoof();

            Car onlyCar = new Car();
            onlyCar.AddWheel();
            onlyCar.OpenOrCloseRoof();

            Motorcycle onlyMotorcycle = new Motorcycle();
            onlyMotorcycle.AddWheel();
            onlyMotorcycle.OpenOrCloseRoof();

            #endregion
        }
    }
}
