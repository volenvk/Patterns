namespace DesignPatterns.Bridge
{
    using System;

    public class Macbook : BaseGadget
    {
        public override void ShowCharge()
        {
            Console.WriteLine(GetEnergy() * 40 / 100);
        }
    }
}