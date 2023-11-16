using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.1
            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();
            Console.WriteLine("введите строку для шифрования:");
            string originalInput = Console.ReadLine();
            string encryptedA = aCipher.encode(originalInput);
            string decryptedA = aCipher.decode(encryptedA);
            Console.WriteLine($"исходный текст: {originalInput}");
            Console.WriteLine($"закодированный а: {encryptedA}");
            Console.WriteLine($"раскодированный а: {decryptedA}");
            string encryptedB = bCipher.encode(originalInput);
            string decryptedB = bCipher.decode(encryptedB);
            Console.WriteLine($"закодированный б: {encryptedB}");
            Console.WriteLine($"раскодированный б: {decryptedB}");
            Console.ReadKey();
            //10.2
            Point point = new Point("красный", true);
            point.DisplayState();
            Circle circle = new Circle("голубой", true, 5);
            circle.DisplayState();
            Console.WriteLine($"круг: {circle.CalculateArea()}");
            Rectangle rectangle = new Rectangle("зеленый", true, 4, 6);
            rectangle.DisplayState();
            Console.WriteLine($"прямоугольник: {rectangle.CalculateArea()}");
            point.MoveHorizontal(3);
            circle.MoveVertical(2);
            rectangle.ChangeColor("желтый");
            Console.ReadKey();
        }
    }
}
