using System;

namespace Visitors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            BMW bmw = new BMW();
            Truck truck = new Truck();

            Promotion promotion = new Promotion();

            //car.Accept(promotion);
            //bmw.Accept(promotion);

            //Markup markup = new Markup();
            //truck.Accept(markup);

            Console.WriteLine(car.Cost);
            Console.WriteLine(bmw.Cost);
            Console.WriteLine(truck.Cost);


        }
    }
}
