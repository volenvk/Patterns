using System;

namespace DesignPatterns.Decorator
{
    public class CondimentPortionSizeCost : IPortionSizeCost
    {
        public double GetCost(PortionSize size)
        {
            switch (size)
            {
                case PortionSize.Big:
                    return 0.20;
                case PortionSize.Medium:
                    return 0.15;
                case PortionSize.Small:
                    return 0.10;
                default:
                    throw new ArgumentOutOfRangeException("cost not set");
            }
        }
    }
}
