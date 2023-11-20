using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containertool.Klassen
{
    internal class Toilette : Container
    {
        private int numberOfToilets = 0;
        
        public int NumberOfToilets { get { return numberOfToilets; } set { numberOfToilets = value; } }

        public Toilette(int xValue, int yValue, int numberOfToilets) : base(xValue, yValue)
        {
            this.numberOfToilets = numberOfToilets;
        }

        public override string ToString()
        {
            return $"Container an X = {xValue} und Y = {yValue}" +
                $"Der Container ist ein Toilette-Container." +
                $"Dieser Container enthält {numberOfToilets} Toiletten." +
                $"Volumen des Containers : {BerechneVolumen()}";
        }
    }
}
