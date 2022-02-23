using System;

namespace DesignPatternStrategyDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            RubberDuck rubberDuck = new();
            MallardDuck mallardDuck = new();

            Console.WriteLine(rubberDuck.DoFly());
            Console.WriteLine(rubberDuck.DoQuack());

            Console.WriteLine(mallardDuck.DoFly());
            Console.WriteLine(mallardDuck.DoQuack());
        }
    }
}
