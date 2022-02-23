using System;
namespace DesignPatternStrategyDucks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new QuackSound();
            flyBehavior = new FlyWithWings();

            Console.WriteLine("I'm a Mallard duck");
        }
    }
}
