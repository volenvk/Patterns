namespace DesignPatterns.Command
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonClick()
        {
            _slot.Execute();
        }
    }
}