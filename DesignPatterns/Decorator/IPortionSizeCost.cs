using System;

namespace DesignPatterns.Decorator
{
    public interface IPortionSizeCost
    {
        double GetCost(PortionSize size);
    }
}
