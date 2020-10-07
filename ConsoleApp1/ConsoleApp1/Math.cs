using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    class Math
    {
        public static bool IsPrime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
