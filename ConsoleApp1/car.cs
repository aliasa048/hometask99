using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class car : vehicle
    {
        public car()
        {
           

        }
         public void AddFuel(int addfuel)
        {
            int capasity = 60;
            int currentfuel = 20;
            if (capasity > currentfuel + addfuel) 
            {
                currentfuel += addfuel;
                Console.WriteLine(currentfuel);
            }
            else
            {
                Console.WriteLine(" maximum seviyyeni kecmesin: ");
            }
        } 
        
         public int FuelCapasity;
    }
    
}
