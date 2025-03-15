using Patrones.Punto4.Commands;
using Punto4.TaskManager.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Punto4.Service
{
   public class Invoker
    {
        public readonly Stack<ICommand> _commandHistory = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                MessageHandler.ShowWarning("No hay comandos para deshacer.");
            }
        }
    }
}
