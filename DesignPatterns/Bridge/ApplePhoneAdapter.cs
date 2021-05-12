namespace DesignPatterns.Bridge
{
    public class ApplePhoneAdapter : BaseAdapter
    {
        public override string GetEnergy() => "1A 5V";
    }
}