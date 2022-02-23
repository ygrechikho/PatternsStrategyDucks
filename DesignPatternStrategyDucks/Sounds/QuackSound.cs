using System;
namespace DesignPatternStrategyDucks
{
    public class QuackSound : QuackBehavior
    {
        string sound = "Quack! Quak-y-quack!";
        public QuackSound()
        {
        }

        public string Quack()
        {
            return sound;
        }
    }
}
