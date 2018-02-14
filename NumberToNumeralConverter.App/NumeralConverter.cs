using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToNumeralConverter.App
{
    public class NumeralConverter
    {
        public int Numberizer(string numeral)
        {
            int result = 0;

            while (numeral.Length > 0)
            {
                if (numeral.StartsWith("C"))
                {
                    result += 100;
                    numeral = numeral.Remove(0, 1);
                    continue;
                }
                if (numeral.StartsWith("XC"))
                {
                    result += 90;
                    numeral = numeral.Remove(0, 2);
                    continue;
                }
                if (numeral.StartsWith("L"))
                {
                    result += 50;
                    numeral = numeral.Remove(0, 1);
                    continue;
                }
                if (numeral.StartsWith("XL"))
                {
                    result += 40;
                    numeral = numeral.Remove(0, 2);
                    continue;
                }
                if (numeral.StartsWith("X"))
                {
                    result += 10;
                    numeral = numeral.Remove(0, 1);
                    continue;
                }
                if (numeral.StartsWith("IX"))
                {
                    result += 9;
                    numeral = numeral.Remove(0, 2);
                    continue;
                }
                if (numeral.StartsWith("V"))
                {
                    result += 5;
                    numeral = numeral.Remove(0, 1);
                    continue;
                }
                if (numeral.StartsWith("IV"))
                {
                    result += 4;
                    numeral = numeral.Remove(0, 2);
                    continue;
                }
                if (numeral.StartsWith("I"))
                {
                    result += 1;
                    numeral = numeral.Remove(0, 1);
                    continue;
                }
                return result;
            }

            return result;
        }
    }
}
