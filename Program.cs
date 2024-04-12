using System;

namespace Shape_Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Shape You Want To Get The Area");
                Console.WriteLine();
                Console.WriteLine("r - Rectangle   p - Parallelogram");
                Console.WriteLine("s - Square");
                Console.WriteLine("c - Circle");
                Console.WriteLine("t - Triangle");
                Console.WriteLine();
                Console.WriteLine("e - Exit");
                Console.Write("> ");

                string option = Console.ReadLine();
                Console.WriteLine();

                if (option == "e")
                {
                    Console.WriteLine("Exiting Program...");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                AreaCalculator(option);
            }
        }

        static void AreaCalculator(string option)
        {
            option = option.ToLower();

            if (option == "r" || option == "s" || option == "c" || option == "t" || option == "p")
            {
                double area = 0;
                switch (option)
                {
                    case "r":
                        Console.Write("Enter Height of the Rectangle (cm): ");
                        float height = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Enter width of the Rectangle (cm): ");
                        float width = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine();

                        area = height * width;

                        Console.WriteLine("The Area of the Rectangle is: " + area + "cm");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;
                    case "s":
                        Console.Write("Enter Length of Side of the Square (cm): ");
                        float length = Convert.ToSingle(Console.ReadLine());

                        area = Math.Pow(length, 2);

                        Console.WriteLine("The Area of the Square is: " + area + "cm");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadKey();
                        Console.WriteLine();

                        break;
                    case "c":
                        Console.Write("Enter Radius of the Circle (cm): ");

                        double radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        area = Math.PI * radius * radius;

                        Console.WriteLine("The Area of the Circle is: " + area + "cm");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadKey();
                        Console.WriteLine();

                        break;
                    case "t":
                        double a = 0;
                        double b = 0;
                        double c = 0;

                        Console.Write("Enter Side a (cm): ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Side b (cm): ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Side c (cm): ");
                        c = Convert.ToDouble(Console.ReadLine());

                        double s = (a + b + c) / 2;

                        area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                        Console.WriteLine("The Area of the Triangle is: " + area + "cm");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadKey();
                        Console.WriteLine();

                        break;
                    case "p":
                        Console.Write("Enter Base (cm): ");
                        double pBase = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Vertical Height (cm): ");
                        double pHeight = Convert.ToDouble(Console.ReadLine());

                        area = pBase * pHeight;

                        Console.WriteLine("The Area of the Parallelogram is: " + area + "cm");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadKey();
                        Console.WriteLine();

                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter a Valid Value [r, c, e (exit)]");
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
