using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        // create Random object (_generator)
        private static Random _generator = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            // user Next() function to get random number
            return _generator.Next(minimumValue, maximumValue + 1);
        }
    }
}
