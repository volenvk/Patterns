namespace ReaderLogFilesByPatterns.Command
{
    using System;

    public class Receiver
    {
        public void Read()
        {
            Console.WriteLine("Read");
        }
        
        public void Write()
        {
            Console.WriteLine("Write");
        }
        
        public void Save()
        {
            Console.WriteLine("Save");
        }
    }
}