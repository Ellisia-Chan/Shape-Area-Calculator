using System;

namespace Shape_Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("  Select Shape You Want To Get The Area");
                Console.WriteLine();
                Console.WriteLine("  r - Rectangle    p - Parallelogram");
                Console.WriteLine("  s - Square      tr - Trapezoid");
                Console.WriteLine("  c - Circle      el - Ellipse");
                Console.WriteLine("  t - Triangle    st - Sector");
                Console.WriteLine();
                Console.WriteLine("  e - Exit");
                Console.Write("  > ");

                string option = Console.ReadLine();
                Console.WriteLine();

                if (option == "e")
                {
                    Console.WriteLine(" Exiting Program...");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                AreaCalculator(option);
            }
        }

        static void AreaCalculator(string option)
        {
            option = option.ToLower();

            if (option == "r" ||
                option == "s" ||
                option == "c" ||
                option == "t" ||
                option == "p" ||
                option == "tr" ||
                option == "el" ||
                option == "st")
            {
                double area = 0;
                switch (option)
                {
                    case "r":
                        try
                        {
                            Console.Write(" Enter Height of the Rectangle (cm): ");
                            float height = Convert.ToSingle(Console.ReadLine());

                            Console.Write(" Enter width of the Rectangle (cm): ");
                            float width = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine();

                            area = height * width;

                            Console.WriteLine(" The Area of the Rectangle is: " + area + "cm");
                            Console.WriteLine();
                            Console.WriteLine(" Press Enter to Continue...");
                            Console.ReadKey();
                            Console.WriteLine();

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Invalid Value. Please Enter a Valid Numeric Value");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1000);
                        }
                        break;

                    case "s":
                        try
                        {

                            Console.Write(" Enter Length of Side of the Square (cm): ");
                            float length = Convert.ToSingle(Console.ReadLine());

                            area = Math.Pow(length, 2);

                            Console.WriteLine(" The Area of the Square is: " + area + "cm");
                            Console.WriteLine();
                            Console.WriteLine(" Press Enter to Continue...");
                            Console.ReadKey();
                            Console.WriteLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Invalid Value. Please Enter a Valid Numeric Value");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1000);
                        }
                        break;

                    case "c":
                        try
                        {
                            Console.Write(" Enter Radius of the Circle (cm): ");

                            double radius = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();

                            area = Math.PI * radius * radius;

                            Console.WriteLine(" The Area of the Circle is: " + area + "cm");
                            Console.WriteLine();
                            Console.WriteLine(" Press Enter to Continue...");
                            Console.ReadKey();
                            Console.WriteLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Invalid Value. Please Enter a Valid Numeric Value");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1000);
                        }
                        break;

                    case "t":
                        try
                        {
                            double a = 0;
                            double b = 0;
                            double c = 0;

                            Console.Write(" Enter Side a (cm): ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write(" Enter Side b (cm): ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write(" Enter Side c (cm): ");
                            c = Convert.ToDouble(Console.ReadLine());

                            double s = (a + b + c) / 2;

                            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                            Console.WriteLine(" The Area of the Triangle is: " + area + "cm");
                            Console.WriteLine();
                            Console.WriteLine(" Press Enter to Continue...");
                            Console.ReadKey();
                            Console.WriteLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Invalid Value. Please Enter a Valid Numeric Value");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1000);
                        }
                        break;

                    case "p":
                        try
                        {
                            Console.Write(" Enter Base (cm): ");
                            double pBase = Convert.ToDouble(Console.ReadLine());
                            Console.Write(" Enter Vertical Height (cm): ");
                            double pHeight = Convert.ToDouble(Console.ReadLine());

                            area = pBase * pHeight;

                            Console.WriteLine(" The Area of the Parallelogram is: " + area + "cm");
                            Console.WriteLine();
                            Console.WriteLine(" Press Enter to Continue...");
                            Console.ReadKey();
                            Console.WriteLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Invalid Value. Please Enter a Valid Numeric Value");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1000);
                        }
                        break;

                    case "tr":
                        try
                        {
                            Console.Write(" Enter Base a (cm): ");
                            double baseA = Convert.ToDouble(Console.ReadLine());
                            Console.Write(" Enter Base b (cm): ");
                            double baseB = Convert.ToDouble(Console.ReadLine());
                            Console.Write(" Enter Vertical Height (cm): ");
                            double height = Convert.ToDouble(Console.ReadLine());

                            area = ((baseA + baseB) / 2) * height;

                            Console.WriteLine(" The Area of the Trapezoid is: " + area + "cm");
                            Console.WriteLine();
                            Console.WriteLine(" Press Enter to Continue...");
                            Console.ReadKey();
                            Console.WriteLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Invalid Value. Please Enter a Valid Numeric Value");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1000);
                        }
                        break;

                    case "el":
                        try
                        {
                            Console.Write(" Enter Major Axis(x) (cm): ");
                            double majorAxis = Convert.ToDouble(Console.ReadLine());
                            Console.Write(" Enter Minor Axis(y) (cm): ");
                            double minorAxis = Convert.ToDouble(Console.ReadLine());

                            area = Math.PI * majorAxis * minorAxis;

                            Console.WriteLine(" The Area of the Ellipse is: " + area + "cm");
                            Console.WriteLine();
                            Console.WriteLine(" Press Enter to Continue...");
                            Console.ReadKey();
                            Console.WriteLine();

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Invalid Value. Please Enter a Valid Numeric Value");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1000);
                        }
                        break;

                    case "st":
                        try
                        {
                            Console.Write(" Enter Radius (cm): ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            Console.Write(" Enter angle in radians: ");
                            double angle = Convert.ToDouble(Console.ReadLine());

                            area = Math.Pow(radius, 2) * angle * Math.PI / 360;
                             
                            Console.WriteLine(" The Area of the Sector is: " + area + "cm");
                            Console.WriteLine();
                            Console.WriteLine(" Press Enter to Continue...");
                            Console.ReadKey();
                            Console.WriteLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Invalid Value. Please Enter a Valid Numeric Value");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1000);
                        }
                        break ;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine(" Please Select a Character in the Selections");
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
