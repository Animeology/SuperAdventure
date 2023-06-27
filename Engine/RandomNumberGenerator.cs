using System;

namespace Engine
{
    public class RandomNumberGenerator
    {
        static Random generator = new Random();

        public int NumberRange(int min, int max)
        {
            return generator.Next(min, max);
        }
    }
}
