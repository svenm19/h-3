using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containertool.Klassen
{
    public class Container
    {
        protected int xValue = 0;
        protected int yValue = 0;
        protected int length = 10;
        protected int height = 10;
        protected int width = 10;
        protected int volumen = 0;

        public int XValue { get { return xValue; } set {  xValue = value; } }
        public int YValue { get { return yValue; } set { yValue = value; } }
        public int Length { get { return length; } set { length = value; } }
        public int Height { get { return height; } set {  height = value; } }
        public int Width { get { return width; } set {  width = value; } }

        public Container (int xValue, int yValue)
        {
            this.xValue = xValue;
            this.yValue = yValue;
            length = 10;
            height = 10;
            width = 10;
            volumen = 0;
        }

        public int BerechneVolumen()
        {
            volumen = length * height * width;
            return volumen;
        }

        public override string ToString()
        {
            return $"Container an X = {xValue} und Y = {yValue} \n" +
                $"Volumen des Containers : {BerechneVolumen()} \n";
        }
    }
}
