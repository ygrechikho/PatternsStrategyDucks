using System;
namespace DesignPatternStrategyDucks
{
    public class MuteSound : QuackBehavior
    {
        public MuteSound()
        {
        }

        public string Quack()
        {
            throw new NotImplementedException();
        }
    }
}
