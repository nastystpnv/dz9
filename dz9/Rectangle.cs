using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    public class Rectangle : Point
    {
        private double length;
        private double width;
        public Rectangle(string color, bool isVisible, double length, double width) : base(color, isVisible)
        {
            this.length = length;
            this.width = width;
        }
        public double CalculateArea()
        {
            return length * width;
        }
        public override void DisplayState()
        {
            Console.WriteLine($"Rectangle - Color: {base.color}, Visible: {base.IsVisible}, Length: {length}, Width: {width}");
        }
    }

}
