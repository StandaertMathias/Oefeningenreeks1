using System;
using System.Collections.Generic;
using System.Text;

namespace Oefeningenreeks1
{
    class Faculteit
    {
        public int Number { get; set; }
        public Faculteit(int number)
        {
            this.Number = number;
        }
        public int Bereken()
        {
            return Faculty(Number);
        }
        public int Faculty(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            return number * Faculty(number - 1);
        }
    }
}
