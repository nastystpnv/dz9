using System;


namespace dz9
{
    public abstract class Figure : IMovable, IColorable
    {
        private string color;
        private bool isVisible;
        public Figure(string color, bool isVisible)
        {
            this.color = color;
            this.isVisible = isVisible;
        }
        public void MoveHorizontal(int distance)
        {
            Console.WriteLine($"Moving horizontally by {distance} units");
        }
        public void MoveVertical(int distance)
        {
            Console.WriteLine($"Moving vertically by {distance} units");
        }
        public void ChangeColor(string newColor)
        {
            this.color = newColor;
            Console.WriteLine($"Changing color to {newColor}");
        }
        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }
        public abstract void DisplayState();
    }
}
