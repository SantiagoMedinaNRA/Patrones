using System;
using Patrones.Punto4.Commands;
using Patrones.Punto4.Service;
using Punto4.TaskManager.Utilities;

TaskManager taskManager = new();
Invoker invoker = new();

while (true)
{
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Crear Tarea");
    Console.WriteLine("2. Completar Tarea");
    Console.WriteLine("3. Deshacer Última Acción");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");

    string? input = Console.ReadLine();
    if (input == "4") break;

    switch (input)
    {
        case "1":
            Console.Write("Ingrese el nombre de la tarea: ");
            string? name = Console.ReadLine();
            ICommand createTaskCommand = new CreateTaskCommand(taskManager, name);
            invoker.ExecuteCommand(createTaskCommand);
            break;

        case "2":
            Console.Write("Ingrese el ID de la tarea a completar: ");
            if (int.TryParse(Console.ReadLine(), out int taskId))
            {
                ICommand completeTaskCommand = new CompleteTaskCommand(taskManager, taskId);
                invoker.ExecuteCommand(completeTaskCommand);    
            }
            else
            {
                MessageHandler.ShowWarning("ID inválido.");
            }
            break;

        case "3":
            invoker.UndoLastCommand();
            break;

        default:
            MessageHandler.ShowSuccess("Opción no válida.");
            break;
    }
    Console.WriteLine("********************");
    Console.WriteLine("");

}
