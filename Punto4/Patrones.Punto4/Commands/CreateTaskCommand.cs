using Patrones.Punto4.Models;
using Patrones.Punto4.Service;
using Punto4.TaskManager.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Punto4.Commands
{
   public class CreateTaskCommand(TaskManager receiver, string name) : ICommand
    {
        private readonly TaskManager _receiver = receiver;
        private UserTask? _task;
        private readonly string _name = name;

        public void Execute()
        {
            _task = _receiver.CreateTask(_name);
        }

        public void Undo()
        {
            if (_task != null)
            {
                _receiver.DeleteTask(_task.Id);
                MessageHandler.ShowInfo($"Deshacer: Tarea {_task.Id} eliminada.");
            }
        }
    }

}
