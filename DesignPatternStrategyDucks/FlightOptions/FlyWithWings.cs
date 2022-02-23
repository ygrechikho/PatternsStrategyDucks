using System;
namespace DesignPatternStrategyDucks
{
    public class FlyWithWings : FlyBehavior
    {
        public string motion = "Flies like butterflies!";
        public FlyWithWings()
        {
        }

        public string Fly()
        {
            return motion;
        }
    }

}
