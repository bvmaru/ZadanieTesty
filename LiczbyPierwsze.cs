using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieTesty
{
    public class LiczbyPierwsze
    {
        public string Sprawdzenie(string userInput)
        {
            try
            {
                int testresult = Int32.Parse(userInput);
                if (testresult < 0)
                {
                    throw new InvalidOperationException("InvalidArgumentException");
                }
            }
            catch (FormatException)
            {
                throw new InvalidOperationException("InvalidArgumentException");
            }

            int counter = 0;
            int result = Int32.Parse(userInput);
            for (int i = 1; i <= result; i++)
            {
                if (result % i == 0)
                {
                    counter++;
                }
            }
            if (counter > 2)
            {
                return "Liczba nie jest liczbą pierwszą";
            }
            else
            {
                return "Liczba jest liczbą pierwszą";
            }
        }
    }
}
