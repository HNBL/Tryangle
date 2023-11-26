using System;
using Tryangle;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Треугольник равностороний? \n [y/n]?");

        string answer = Convert.ToString(Console.ReadLine()); 

        switch (answer) 
        {
            case "y":
               Console.WriteLine("Ведите значение стороны равностороннего треугольника ");
               
                int side=int.Parse(Console.ReadLine());
                Square.Tryangle(side);

                break;
            default:
                Console.WriteLine("Введите три стороны треугольнка?");
                int a=int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
               
                Square.Tryangle (a,b,c);

                break;
        
        
        
        }

    }
}


