using System;

namespace DesignPatterns.Decorator
{
    public class BeveragePortionSizeCost : IPortionSizeCost
    {
        public double GetCost(PortionSize size)
        {
            switch (size)
            {
                case PortionSize.Big:
                    return 0.50;
                case PortionSize.Medium:
                    return 0.45;
                case PortionSize.Small:
                    return 0.30;
                default:
                    throw new ArgumentOutOfRangeException("cost not set");
            }
        }
    }
}
