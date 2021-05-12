namespace DesignPatterns.Bridge
{
    using System;

    public class ApplePhone : BaseGadget
    {
        public override void ShowCharge()
        {
            Console.WriteLine(GetEnergy() * 5 / 100);
        }
    }
}