using System;

namespace Exercise_5
{
    public class Time
    {
        public int Hours
        {set; get;}
        public int Minutes
        {set; get;}

        // adding two objects together
        public static Time operator+ (Time a, Time b)
        {
            Time addedTime = new Time();
            addedTime.Hours = a.Hours + b.Hours;
            addedTime.Minutes = a.Minutes + b.Minutes;
            return addedTime;
        }

        // adding an integer value to an object
        public static Time operator+ (int variable, Time c)
        {
            Time sumTime = new Time();
            // sumTime = variable + c.Minutes;  how to extract integer value from an object?
            return null;
        }

        public override string ToString()
        {
            return "Hours: " + Hours + " Minutes: " + Minutes;
        }
    }
}