using System;
namespace DesignPatternStrategyDucks
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public FlyBehavior FlyBehavior
        {
            get
            {
                return flyBehavior;
            }
            set
            {
                flyBehavior = value;
            }
        }

        public QuackBehavior QuackBehavior
        {
            get
            {
                return quackBehavior;
            }
            set
            {
                quackBehavior = value;
            }
        }

        public string DoFly()
        {
            return flyBehavior.Fly();
        }

        public string DoQuack()
        {
            return quackBehavior.Quack();
        }
    }
}
