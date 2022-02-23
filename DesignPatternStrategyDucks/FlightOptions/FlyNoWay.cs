using System;
namespace DesignPatternStrategyDucks
{
    public class FlyNoWay : FlyBehavior
    {
        public string motion = "Floats.";

        public FlyNoWay()
        {
        }

        public string Fly()
        {
            return motion;
        }
    }
}
