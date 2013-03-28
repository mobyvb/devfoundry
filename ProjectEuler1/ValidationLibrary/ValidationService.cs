using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidationLibrary
{
    public class ValidationService
    {
        public static bool ParsesAsInt(string str)
        {
            int x = 0;
            if (int.TryParse(str, out x))
            {
                return true;
            }
            return false;
        }

        public static bool IsPositive(int x)
        {
            if (x > 0) return true;
            return false;
        }
    }
}
