using System;

namespace Exercise_9
{
    public class Car
    {
        public string Color
        {set; get;}
        public int EngineSize
        {set; get;}
        public int FuelEconomy
        {set; get;}

        public override string ToString()
        {
            return "Car Details: \n\tColor - " + Color + 
            "\n\tEngine Size - " + EngineSize + "\n\tFuel Economy - " + FuelEconomy;
        }
    }
}