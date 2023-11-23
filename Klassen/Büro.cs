using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containertool.Klassen
{
    public class Büro : Container
    {
        private int numberOfComputers = 0;

        public int Computers { get {  return numberOfComputers; } set {  numberOfComputers = value; } }

        public Büro(int xValue, int yValue, int numberOfComputers) : base (xValue, yValue)
        {
            this.numberOfComputers = numberOfComputers;
        }

        public override string ToString()
        {
            return $"Container an X = {xValue} und Y = {yValue} \n" +
                $"Der Container ist ein Toilette-Container. \n" +
                $"Dieser Container enthält {numberOfComputers} Computer. \n" +
                $"Volumen des Containers : {BerechneVolumen()} \n";
        }
    }
}
