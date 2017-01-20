using System;
//Calculate rectangle perimeter, area and diagonal,
//by given width and height
class Program
{
    static void Main(string[] args)
    {
        //Read input data from console
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        //Calculate rectangle parameters
        double perimeter = 2 * (width + height);
        double area = width * height;
        double diagonalLenght = Math.Sqrt(width * width + height * height);

        //Print data on console
        Console.WriteLine($"{perimeter}\n{area}\n{diagonalLenght}");
    }
}