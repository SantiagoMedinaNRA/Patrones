using Patrones.Punto4.Models;
using Punto4.TaskManager.Utilities;

namespace Patrones.Punto4.Service
{
   public class TaskManager
    {
        public readonly List<UserTask> tasks = new();
        private int nextId = 1;

        public UserTask CreateTask(string name)
        {
            try
            {
                var task = new UserTask(nextId++, name);
                tasks.Add(task);
                MessageHandler.ShowSuccess($"Tarea creada: {task.Id} - {task.Name}");
                return task;
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex, "CreateTask");
                return null;
            }
        }

        public void CompleteTask(int id)
        {
            try
            {
                var task = tasks.Find(t => t.Id == id);
                if (task != null)
                {
                    task.MarkAsCompleted();
                    MessageHandler.ShowSuccess($"Tarea completada: {task.Id} - {task.Name}");
                }
                else
                {
                    MessageHandler.ShowWarning("Tarea no encontrada.");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex, "CompleteTask");
            }
        }

        public void DeleteTask(int id)
        {
            try
            {
                var task = tasks.Find(t => t.Id == id);
                if (task != null)
                {
                    tasks.Remove(task);
                    MessageHandler.ShowSuccess($"Tarea eliminada: {task.Id} - {task.Name}");
                }
                else
                {
                    MessageHandler.ShowWarning("Tarea no encontrada.");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex, "DeleteTask");
            }
        }

        public UserTask GetTask(int id) => tasks.Find(t => t.Id == id);
    }

}

