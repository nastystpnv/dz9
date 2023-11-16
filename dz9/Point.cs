using System;


namespace dz9
{
    public class Point : Figure
    {
        public Point(string color, bool isVisible) : base(color, isVisible) { }
        public override void DisplayState()
        {
            Console.WriteLine($"Point - Color: {base.color}, Visible: {base.IsVisible}");
        }
    }
}
