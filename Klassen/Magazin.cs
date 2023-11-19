using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausuebung_03.Klassen
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
            return $"Container an X = {xValue} und Y = {yValue}" +
                $"Der Container ist ein Toilette-Container." +
                $"Dieser Container enthält {numberOfItems} Artikel." +
                $"Volumen des Containers : {BerechneVolumen()}";
        }
    }
}
