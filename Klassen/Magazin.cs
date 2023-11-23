using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containertool.Klassen
{
    internal class Magazin : Container
    {
        private int numberOfItems = 0;

        public int NumberOfItems { get { return numberOfItems; } set { numberOfItems = value; } }

        public Magazin (int xValue, int yValue, int numberOfItems) : base (xValue, yValue)
        {
            this.numberOfItems = numberOfItems;
        }

        public override string ToString()
        {
            return $"Container an X = {xValue} und Y = {yValue} \n" +
                $"Der Container ist ein Toilette-Container. \n" +
                $"Dieser Container enthält {numberOfItems} Artikel. \n" +
                $"Volumen des Containers : {BerechneVolumen()}  \n";
        }
    }
}
