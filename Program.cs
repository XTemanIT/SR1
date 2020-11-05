using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab1CSharp
{
    class Cars
    {
        public int age;
        public string color;
        public int cost;
        public int ls;

        public void GetInfo()
        {
            Console.WriteLine($"Год: {age}\nЦвет: {color}\nЦена: {cost}\nЛошадок: {ls}\n");
        }

        public Cars(int age, string color, int cost, int ls)
        {
            this.age = age;
            this.color = color;
            this.cost = cost;
            this.ls = ls;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int age, cost, ls;
            string color;
            List<Cars> cars = new List<Cars>();
            cars.Add(new Cars(2222, "Red", 35000, 300));
            cars.Add(new Cars(3333, "Emerald", 20000, 170));
            cars.Add(new Cars(4444, "White", 99999, 400));
            cars.Add(new Cars(8888, "Black", 888888, 8888));
            cars.Add(new Cars(8888, "Black", 88888, 888));
            age = Convert.ToInt32(Console.ReadLine());
            color = Console.ReadLine();
            cost = Convert.ToInt32(Console.ReadLine());
            ls = Convert.ToInt32(Console.ReadLine());
            var selectedCars = cars.Where(x => x.age == age &&
            x.color == color &&
            x.cost == cost &&
            x.ls == ls).ToList();
            selectedCars.ForEach(x => { Console.WriteLine($"Age: {x.age} Color: {x.color} Cost: {x.cost} LS: {x.ls}"); });
        }
    }
}
