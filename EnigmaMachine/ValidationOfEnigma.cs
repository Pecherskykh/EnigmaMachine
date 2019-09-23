using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    static class ValidationOfEnigma
    {
        public static bool BelongAlphabet(string str)
        {
            foreach (char s in str)
            {
                if (Enigma.alphabet.IndexOf(s) < 0)
                    return false;
            }
            return true;
        }

        public static bool SymbolsRepeated(string str)
        {
            foreach (char symbol in str)
            {
                if (str.Count(s => s == symbol) > 1)
                    return true;
            }
            return false;
        }

        public static bool AllNumbersIntoInterval(int[] arr)
        {
            foreach (int n in arr)
            {
                if (n < 1 || n > 26)
                    return false;
            }
            return true;
        }
    }
}