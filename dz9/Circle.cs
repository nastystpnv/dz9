using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    public class Circle : Point
    {
        private double radius;

        public Circle(string color, bool isVisible, double radius) : base(color, isVisible)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override void DisplayState()
        {
            Console.WriteLine($"Circle - Color: {base.color}, Visible: {base.IsVisible}, Radius: {radius}");
        }
    }

}
