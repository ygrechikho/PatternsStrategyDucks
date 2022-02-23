using System;
namespace DesignPatternStrategyDucks
{
    public class SqueakSound : QuackBehavior
    {
        string sound = "Squeak! Nes-queack...";
        public SqueakSound()
        {
        }

        public string Quack()
        {
            return sound;
        }
    }
}
