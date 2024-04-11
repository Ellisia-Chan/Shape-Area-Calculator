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
                Console.WriteLine("r - Rectangle");
                Console.WriteLine("c - Circle");
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

            if (option == "r" || option == "c")
            {
                float area;
                switch (option)
                {
                    case "r":
                        Console.Write("Enter Height of the Rectangle: ");
                        float height = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Enter width of the Rectangle: ");
                        float width = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine();

                        area = height * width;

                        Console.WriteLine("The Area of the Rectangle is: " + area);
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case "c":
                        Console.Write("Enter Radius of the Circle: ");                        

                        float radius = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine();

                        area = (float)Math.PI * radius * radius;

                        Console.WriteLine("The Area of the Circle is: " + area);
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadKey();
                        Console.WriteLine();
                        
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
