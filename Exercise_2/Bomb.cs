using System;

namespace Exercise_2
{
    public class Bomb : IExplodable<Bomb>
    {
        private double radius;

        public Bomb()
        {
            // no-args
        }
        public void Explode(Bomb radius)
        {
            // takes the radius and returns the diameter

            double diameter = this.radius * 2.0; // The issues is here.  I'm not sure how to operate on the radius when it is of type Object.
            Console.WriteLine("BOOM!" + "\nExplosion diameter: " + diameter);
        }
    }
}