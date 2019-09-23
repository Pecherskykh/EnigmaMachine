using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    class Rotor
    {
        public string Wiring { get; set; }
        public int Notch { get; set; }
        public int? Notch2 { get; set; }
        public int Ringstellung { get; set; }
        private int position;
        public int Position
        {
            get { return position; }
            set
            {
                if (value < 0)
                    throw new Exception();
                else
                {
                    if (value < 26)
                        position = value;
                    else
                        position = value % 26;
                }
            }
        }
    }
}