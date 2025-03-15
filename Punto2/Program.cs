using Punto2.Services;

var messageService = new MessageService();

var devices = new Dictionary<string, DeviceService>();

Console.WriteLine("Equipo # 2, Punto #2");
Console.WriteLine("Bienvenido al sistema de mensajería en tiempo real con el patrón (Observer).");
Console.WriteLine("Por favor seleccionar la opción deseada:");
Console.WriteLine("  1) add <NombreDispositivo>");
Console.WriteLine("  2) remove <NombreDispositivo>");
Console.WriteLine("  3) send <Mensaje>");
Console.WriteLine("  4) list");
Console.WriteLine("  5) exit");
Console.WriteLine();

while (true)
{
  Console.Write("Ingresa un comando: "); // Ejemplo add Celular  |  send Hola  |  list  |  exit
  var input = Console.ReadLine();

  if (string.IsNullOrWhiteSpace(input))
  {
    continue;
  }

  var parts = input.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
  var command = parts[0].ToLower();

  switch (command)
  {
    case "add":
      if (parts.Length < 2)
      {
        Console.WriteLine("Uso: add <NombreDispositivo>");
        break;
      }

      var deviceNameToAdd = parts[1];
      if (devices.ContainsKey(deviceNameToAdd))
      {
        Console.WriteLine($"Ya existe un dispositivo con el nombre '{deviceNameToAdd}'.");
      }
      else
      {
        var newDevice = new DeviceService(deviceNameToAdd);
        // Lo guardamos en el diccionario
        devices[deviceNameToAdd] = newDevice;
        // Suscribimos al MessageService
        messageService.Attach(newDevice);
        Console.WriteLine($"Dispositivo '{deviceNameToAdd}' suscrito correctamente.");
      }
      break;

    case "remove":
      if (parts.Length < 2)
      {
        Console.WriteLine("Uso: remove <NombreDispositivo>");
        break;
      }

      var deviceNameToRemove = parts[1];
      if (devices.ContainsKey(deviceNameToRemove))
      {
        var deviceToRemove = devices[deviceNameToRemove];
        messageService.Detach(deviceToRemove);
        // Lo quitamos del diccionario
        devices.Remove(deviceNameToRemove);
        Console.WriteLine($"Dispositivo '{deviceNameToRemove}' desuscrito correctamente.");
      }
      else
      {
        Console.WriteLine($"No se encontró el dispositivo '{deviceNameToRemove}'.");
      }
      break;

    case "send":
      if (parts.Length < 2)
      {
        Console.WriteLine("Uso: send <Mensaje>");
        break;
      }
      var message = parts[1];
      Console.WriteLine($"Enviando mensaje: {message}");
      messageService.ReceiveMessage(message);
      break;

    case "list":
      if (devices.Count == 0)
      {
        Console.WriteLine("No hay dispositivos suscritos.");
      }
      else
      {
        Console.WriteLine("Dispositivos suscritos actualmente:");
        foreach (var kvp in devices)
        {
          Console.WriteLine(" - " + kvp.Key);
        }
      }
      break;

    case "exit":
      Console.WriteLine("Saliendo de la aplicación...");
      return;

    default:
      Console.WriteLine("Comando no reconocido. Intenta con: add, remove, send, list, exit");
      break;
  }

  Console.WriteLine();
}
        