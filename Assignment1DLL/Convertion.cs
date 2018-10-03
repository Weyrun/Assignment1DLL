using System;
using System.Runtime.InteropServices.ComTypes;

namespace Assignment1DLL
{
    public static class Convertion
    {
        private const double constant = 28.3495231;

        public static double ConvertToOunces(double input)
        {
            return input / constant;
        }

        public static double ConvertToGram(double input)
        {
            return input * constant;
        }
    }
}
