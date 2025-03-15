namespace Punto3.Services
{
  public class NewDigitalPaymentAdapter : IPayment
  {
    private readonly NewDigitalPaymentSystem _newPaymentSystem;

    public NewDigitalPaymentAdapter(NewDigitalPaymentSystem newPaymentSystem)
    {
      _newPaymentSystem = newPaymentSystem;
    }

    public void ProcesarPago(decimal amount)
    {
      double totalEnDouble = (double)amount;
      string token = _newPaymentSystem.GenerarToken();

      //Autenticar token
      bool tokenValido = _newPaymentSystem.AutenticarToken(token);
      if (!tokenValido)
      {
        Console.WriteLine("[Adapter] No se puede iniciar el pago debido a falla en la autenticación del token.");
        return;
      }

      //Iniciar pago
      bool exito = _newPaymentSystem.IniciarPago(totalEnDouble);

      if (exito)
      {
        Console.WriteLine("[Adapter] Pago exitoso a través del nuevo sistema digital.");
      }
      else
      {
        Console.WriteLine("[Adapter] El pago falló en el nuevo sistema digital.");
      }
    }
  }
}
