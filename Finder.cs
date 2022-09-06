using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLibrary
{
    public class Finder
    {
        public static double FindSquare(double radius)
        {
            if (radius <= 0) return -1;

            var square = Math.PI * Math.Pow(radius, 2);

            return square;
        }

        public static double FindSquare(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return -1;

            var longest = Math.Max(Math.Max(a, b), c);
            double short1, short2;

            if (longest == a)
            {
                short1 = b;
                short2 = c;
            }
            else if (longest == b)
            {
                short1 = a;
                short2 = c;
            }
            else
            {
                short1 = a;
                short2 = b;
            }

            if (longest > short1 + short2) return -1;

            double square;

            if (Math.Pow(longest, 2) == (Math.Pow(short1, 2) + Math.Pow(short2, 2)))
            {
                square = (short1 * short2) / 2;
                return square;
            }
            else
            {
                var p = (a + b + c) / 2;
                square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return square;
            }
        }
    }
}
