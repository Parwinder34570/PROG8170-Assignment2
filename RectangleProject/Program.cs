using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width;
            int length;

            //Take User Input (Rectangle Length)
            do
            {
                Console.Write("\nEnter value for rectangle length (integer value only): ");
                Boolean flag = int.TryParse(Console.ReadLine(), out length);
                if (flag == false || length <= 0)
                {
                    Console.WriteLine("\n** ERROR: Value for rectangle length must be greater than 0. Try again !!");
                }
                else
                {
                    break;
                }
            } while (true);

            //Take User Input (Rectangle Width)
            do
            {
                Console.Write("\nEnter value for rectangle width (integer value only): ");
                Boolean flag = int.TryParse(Console.ReadLine(), out width);
                if (flag == false || width <= 0)
                {
                    Console.WriteLine("\n** ERROR: Value for rectangle width must be greater than 0. Try again !!");
                }
                else
                {
                    break;
                }
            } while (true);

            //Create Rectangle Object
            Rectangle rectangle = new Rectangle(width, length);

            int userChoice;
            do
            {
                ShowMainMenu();
                Console.Write("\nEnter your choice: ");
                Boolean flag = int.TryParse(Console.ReadLine(), out userChoice);
                if (flag == false || userChoice < 1 || userChoice > 7)
                {
                    Console.WriteLine("\n** ERROR: You have entered invalid option. Try again !!");
                }
                else
                {
                    if (userChoice == 1)
                    {
                        length = rectangle.GetCurrentLength();
                        Console.WriteLine("Rectangle current length: "+length);
                    }
                    else if (userChoice == 2)
                    {
                        //Taking User Input (Rectangle Length Change)
                        do
                        {
                            Console.Write("\nEnter value for rectangle length (integer value only): ");
                            flag = int.TryParse(Console.ReadLine(), out length);
                            if (flag == false || length <= 0)
                            {
                                Console.WriteLine("\n** ERROR: Value for rectangle length must be greater than 0. Try again !!");
                            }
                            else
                            {
                                break;
                            }

                        } while (true);
                        length = rectangle.SetNewLength(length);
                        Console.WriteLine("Rectangle current length: " + length);
                    }
                    else if (userChoice == 3)
                    {
                        width = rectangle.GetCurrentWidth();
                        Console.WriteLine("Rectangle current width: " + width);
                    }
                    else if (userChoice == 4)
                    {
                        //Taking User Input (Rectangle Width Change)
                        do
                        {
                            Console.Write("\nEnter value for rectangle width (integer value only): ");
                            flag = int.TryParse(Console.ReadLine(), out width);
                            if (flag == false || width <= 0)
                            {
                                Console.WriteLine("\n** ERROR: Value for rectangle width must be greater than 0. Try again !!");
                            }
                            else
                            {
                                break;
                            }

                        } while (true);
                        width = rectangle.SetNewWidth(width);
                        Console.WriteLine("Rectangle current width: " + width);
                    }
                    else if (userChoice == 5)
                    {
                        int perimeter = rectangle.GetPerimeter();
                        Console.WriteLine("Rectangle perimeter: " + perimeter);
                    }
                    else if (userChoice == 6)
                    {
                        int area = rectangle.GetArea();
                        Console.WriteLine("Rectangle perimeter: " + area);
                    }
                    else
                    {
                        Console.WriteLine("\nProgram Exited !!");
                        break;
                    }
                }
            } while (true);


            Console.ReadKey();
        }

        public static void ShowMainMenu()
        {
            Console.WriteLine("\n\nMAIN MENU");
            Console.WriteLine("".PadRight(30, '-'));
            Console.WriteLine("1".PadRight(2) + "Get Rectangle Length");
            Console.WriteLine("2".PadRight(2) + "Change Rectangle Length");
            Console.WriteLine("3".PadRight(2) + "Get Rectangle Width");
            Console.WriteLine("4".PadRight(2) + "Change Rectangle Width");
            Console.WriteLine("5".PadRight(2) + "Get Rectangle Perimeter");
            Console.WriteLine("6".PadRight(2) + "Get Rectangle Area");
            Console.WriteLine("7".PadRight(2) + "Exit");
        }
    }

    
}
