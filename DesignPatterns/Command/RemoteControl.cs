namespace DesignPatterns.Command
{
    using System.Collections.Generic;

    public class RemoteControl
    {
        private readonly Dictionary<int, ICommand> _onCommands;
        private ICommand _undoCommand;

        public RemoteControl(ICommand undoCommand)
        {
            _undoCommand = undoCommand;
            _onCommands = new Dictionary<int, ICommand>();
        }
        
        public void SetCommand(int slot, ICommand command)
        {
            if (!_onCommands.ContainsKey(slot))
            {
                _onCommands[slot] = command;
            }
        }

        public void ButtonClick(int slot)
        {
            if (_onCommands.ContainsKey(slot))
            {
                _onCommands[slot].Execute();
                _undoCommand = _onCommands[slot];
            }
        }

        public void ButtonUndoClick()
        {
            _undoCommand.Undo();
        }
    }
}