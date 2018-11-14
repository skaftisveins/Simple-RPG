using System;

namespace Engine
{
    public class RandomNumberGenerator
    {
        private static Random _genarator = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _genarator.Next(minimumValue, maximumValue + 1);
        }
    }
}
