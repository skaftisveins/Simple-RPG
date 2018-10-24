using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
