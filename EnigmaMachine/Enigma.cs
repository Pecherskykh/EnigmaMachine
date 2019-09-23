using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    static class Enigma
    {
        public static event Action<string, string, string> ShowRotorsPosition;
        public static readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static char Encrypt(char symbol, string steckerSettings, List<Rotor> rotors, string reflector)
        {
            Increment_Rotors(rotors);
            symbol = Stecker(symbol, steckerSettings);

            ShowRotorsPosition(alphabet[rotors[2].Position].ToString(), alphabet[rotors[1].Position].ToString(), alphabet[rotors[0].Position].ToString());

            for (int j = 0; j < rotors.Count; ++j)
                symbol = Method(symbol, rotors[j], true);

            symbol = reflector[alphabet.IndexOf(symbol)];

            for (int j = rotors.Count - 1; j >= 0; --j)
                symbol = Method(symbol, rotors[j], false);
            symbol = Stecker(symbol, steckerSettings);

            return symbol;
        }

        private static char Stecker(char symbol, string steckerSettings)
        {
            int index = steckerSettings.IndexOf(symbol);
            if (index >= 0)
            {
                if (index % 2 == 0)
                    symbol = steckerSettings[index + 1];
                else
                    symbol = steckerSettings[index - 1];
            }
            return symbol;
        }

        private static void Increment_Rotors(List<Rotor> rotors)
        {
            if (rotors[1].Position == rotors[1].Notch || rotors[1].Position == rotors[1].Notch2)
            {
                for (int i = 0; i < 3; ++i)
                    ++rotors[i].Position;
            }
            else if (rotors[0].Position == rotors[0].Notch || rotors[0].Position == rotors[0].Notch2)
            {
                ++rotors[0].Position;
                ++rotors[1].Position;
            }
            else
                ++rotors[0].Position;
        }

        private static char Method(char symbol, Rotor rotor, bool forward)
        {
            int wiringPosition = rotor.Position - rotor.Ringstellung;
            if (wiringPosition < 0)
                wiringPosition = wiringPosition + 26;
            int index = alphabet.IndexOf(symbol) + wiringPosition;
            if (index >= 26)
                index = index - 26;
            if (forward)
            {
                symbol = rotor.Wiring[index];
                index = alphabet.IndexOf(symbol) - wiringPosition;
            }
            else
            {
                symbol = alphabet[index];
                index = rotor.Wiring.IndexOf(symbol) - wiringPosition;
            }
            if (index < 0)
                index = index + 26;
            symbol = alphabet[index];
            return symbol;
        }
    }
}