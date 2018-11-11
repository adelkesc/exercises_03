using System;

namespace Exercise_2
{
    public interface IExplodable<T>
    {
        void Explode(T radius);
    }
}