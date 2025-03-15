namespace Punto3.Services
{
  public class NewDigitalPaymentSystem
  {
    public string GenerarToken()
    {
      var random = new Random();
      var token = random.Next(100000, 999999).ToString();
      Console.WriteLine($"[Nuevo Sistema Digital] Token generado: {token}");
      return token;
    }

    public bool AutenticarToken(string token)
    {
      bool esValido = !token.EndsWith("0");
      Console.WriteLine(esValido
          ? "[Nuevo Sistema Digital] Token autenticado exitosamente."
          : "[Nuevo Sistema Digital] Token inválido o expirado.");
      return esValido;
    }

    public bool IniciarPago(double total)
    {
      Console.WriteLine($"[Nuevo Sistema Digital] Iniciando pago de {total:C2}...");
      return true;
    }
  }
}
