using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containertool.Klassen
{
    internal class Umkleide : Container
    {
        private int numberOfSeats = 0;
        private int numberOfLockers = 0;

        public int NumberOfSeats { get { return numberOfSeats; } set { numberOfSeats = value; } }

        public int NumberOfLockers { get { return numberOfLockers; } set { numberOfLockers = value; } }

        public Umkleide(int xValue, int yValue, int numberOfSeats, int numberOfLockers) : base (xValue, yValue)
        { 
            this.numberOfSeats = numberOfSeats;
            this.numberOfLockers = numberOfLockers;
        }

        public override string ToString()
        {
            return $"Container an X = {xValue} und Y = {yValue} \n" +
                $"Der Container ist ein Umkleide-Container. \n" +
                $"Dieser Container enthält {numberOfSeats} Sitzplätze und {numberOfLockers} Schließfächer. \n" +
                $"Volumen des Containers : {BerechneVolumen()}  \n";
        }
    }
}
