using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//using Java.Lang;

namespace Containertool.Klassen
{
    internal class Pausenraum : Container
    {
        private int numberOfMagazines = 0;
        private int numberOfSeats = 0;

        public int NumberOfMagazines { get { return numberOfMagazines; } set { numberOfMagazines = value; } }

        public int NumberOfSeats { get { return numberOfSeats; } set { numberOfSeats = value; } }

        public Pausenraum (int xValue, int yValue, int numberOfMagazines, int numberOfSeats) : base(xValue, yValue)
        {
            this.numberOfMagazines = numberOfMagazines;
            this.numberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"Container an X = {xValue} und Y = {yValue}  \n" +
                $"Der Container ist ein Pausenraum-Container. \n" +
                $"Dieser Container enthält {numberOfMagazines} Zeitschriften und {numberOfSeats} Sitzplätze. \n" +
                $"Volumen des Containers : {BerechneVolumen()} \n";
        }
    }
}
