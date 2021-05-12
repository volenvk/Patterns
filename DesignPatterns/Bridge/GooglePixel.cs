namespace DesignPatterns.Bridge
{
    using System;

    public class GooglePixel : BaseGadget
    {
        public override void ShowCharge()
        {
            Console.WriteLine((double)GetEnergy() * 50 / 100);
        }
    }
}