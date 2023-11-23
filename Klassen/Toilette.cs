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
            return $"Container an X = {xValue} und Y = {yValue}  \n" +
                $"Der Container ist ein Toilette-Container. \n" +
                $"Dieser Container enthält {numberOfToilets} Toiletten. \n" +
                $"Volumen des Containers : {BerechneVolumen()} \n";
        }
    }
}
