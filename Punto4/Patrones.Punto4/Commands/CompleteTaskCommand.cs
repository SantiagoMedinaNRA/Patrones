using Patrones.Punto4.Service;
using Punto4.TaskManager.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Punto4.Commands
{
    public class CompleteTaskCommand : ICommand
    {
        private readonly TaskManager _receiver;
        private readonly int _taskId;

        public CompleteTaskCommand(TaskManager receiver, int taskId)
        {
            _receiver = receiver;
            _taskId = taskId;
        }

        public void Execute()
        {
            _receiver.CompleteTask(_taskId);
        }

        public void Undo()
        {
            MessageHandler.ShowWarning("Undo no soportado para completar tareas.");
        }
    }
}
