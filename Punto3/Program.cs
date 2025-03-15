using Punto3.Services;

IPayment tarjeta = new CreditCardPayment();
IPayment paypal = new PayPalPayment();
var nuevoSistema = new NewDigitalPaymentSystem();
IPayment nuevoSistemaAdapter = new NewDigitalPaymentAdapter(nuevoSistema);

while (true)
{
  Console.WriteLine("\nEquipo # 2, Punto #3");
  Console.WriteLine("Seleccione un método de pago (o escriba 'salir' para terminar):");
  Console.WriteLine("1) Tarjeta de Crédito");
  Console.WriteLine("2) PayPal");
  Console.WriteLine("3) Nuevo Sistema Digital");
  Console.Write("Opción: ");

  string? opcion = Console.ReadLine();
  if (opcion == null) continue;

  if (opcion.ToLower() == "salir")
  {
    Console.WriteLine("Saliendo del programa...");
    break;
  }

  IPayment? metodoSeleccionado = null;
  switch (opcion)
  {
    case "1":
      metodoSeleccionado = tarjeta;
      break;
    case "2":
      metodoSeleccionado = paypal;
      break;
    case "3":
      metodoSeleccionado = nuevoSistemaAdapter;
      break;
    default:
      Console.WriteLine("Opción inválida. Intente de nuevo.");
      continue;
  }

  Console.Write("Ingrese el monto a pagar: ");
  string? montoStr = Console.ReadLine();

  if (!decimal.TryParse(montoStr, out decimal monto))
  {
    Console.WriteLine("Monto inválido. Intente de nuevo.");
    continue;
  }

  // Procesar el pago con el método seleccionado
  Console.WriteLine("\nProcesando el pago...");
  metodoSeleccionado.ProcesarPago(monto);
}