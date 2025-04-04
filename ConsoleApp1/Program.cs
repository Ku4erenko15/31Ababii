using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Выберите вариант: ");
                Console.WriteLine("1. Добавить новую фигуру");
                Console.WriteLine("2. Просмотреть все фигуры");
                Console.WriteLine("3. Просмотреть сведения о фигуре");
                Console.WriteLine("4. Изменить свойства фигуры");
                Console.WriteLine("5. Удалить фигуру");
                Console.WriteLine("6. Выход");
               
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewFigure(figures);
                        break;
                    case "2":
                        ViewAllFigures(figures);
                        break;
                    case "3":
                        ViewFigureDetails(figures);
                        break;
                    case "4":
                        EditFigureProperties(figures);
                        break;
                    case "5":
                        RemoveFigure(figures);
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            Console.ReadKey();
        }

        static void AddNewFigure(List<Figure> figures)
        {
            Console.WriteLine("Choose figure type:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Circle");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter side1: ");
                    double side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side2: ");
                    double side2 = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Rectangle(side1, side2));
                    break;
                case "2":
                    Console.Write("Enter side: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Square(side));
                    break;
                case "3":
                    Console.Write("Enter side1: ");
                    double tSide1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side2: ");
                    double tSide2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side3: ");
                    double tSide3 = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Triangle(tSide1, tSide2, tSide3));
                    break;
                case "4":
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Circle(radius));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void ViewAllFigures(List<Figure> figures)
        {
            Console.WriteLine("Figures in memory:");
            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {figures[i].Name}");
            }
        }

        static void ViewFigureDetails(List<Figure> figures)
        {
            Console.Write("Enter figure number to view: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < figures.Count)
            {
                figures[index].Print();
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }

        static void EditFigureProperties(List<Figure> figures)
        {
            Console.Write("Enter figure number to edit: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < figures.Count)
            {
                Figure figure = figures[index];
                if (figure is Rectangle rect)
                {
                    Console.Write("Enter new side1: ");
                    rect.Side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter new side2: ");
                    rect.Side2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (figure is Square square)
                {
                    Console.Write("Enter new side: ");
                    square.Side1 = Convert.ToDouble(Console.ReadLine());
                }
                else if (figure is Triangle triangle)
                {
                    Console.Write("Enter new side1: ");
                    triangle.Side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter new side2: ");
                    triangle.Side2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter new side3: ");
                    triangle.Side3 = Convert.ToDouble(Console.ReadLine());
                }
                else if (figure is Circle circle)
                {
                    Console.Write("Enter new radius: ");
                    circle.Radius = Convert.ToDouble(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }

        static void RemoveFigure(List<Figure> figures)
        {
            Console.Write("Enter figure number to remove: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < figures.Count)
            {
                figures.RemoveAt(index);
                Console.WriteLine("Figure removed.");
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }     
    }    
}

