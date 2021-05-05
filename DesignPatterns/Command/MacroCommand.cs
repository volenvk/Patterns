namespace DesignPatterns.Command
{
    using System.Collections.Generic;

    public class MacroCommand : ICommand
    {
        private readonly ICollection<ICommand> _commands;

        public MacroCommand()
        {
            _commands = new List<ICommand>();
        }

        public void Add(ICommand command)
        {
            _commands.Add(command);
        }
        
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }
}