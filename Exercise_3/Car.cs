using System;
using System.Collections.Generic;

namespace Exercise_3
{
    public class Car
    {
        private string name;

        public Car(string name)
        {
            this.name = name;
        }  

        public string getCarName()
        {
            return name;
        }
    } 
}