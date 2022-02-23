using System;
namespace DesignPatternStrategyDucks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new SqueakSound();
            flyBehavior = new FlyNoWay();

            Console.WriteLine("I'm a Rubber duck");
        }
    }     
}
