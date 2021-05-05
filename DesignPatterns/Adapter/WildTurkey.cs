namespace DesignPatterns.Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            throw new System.NotImplementedException();
        }

        public void Fly()
        {
            throw new System.NotImplementedException();
        }

        public void Display()
        {
            throw new System.NotImplementedException();
        }
    }
}