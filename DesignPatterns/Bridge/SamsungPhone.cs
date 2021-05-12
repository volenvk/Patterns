namespace DesignPatterns.Bridge
{
    using System;

    public class SamsungPhone : BaseGadget
    {
        public override void ShowCharge()
        {
            Console.WriteLine(GetEnergy() * 10 / 100);
        }
    }
}