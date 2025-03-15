using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3.Services
{
  public class CreditCardPayment : IPayment
  {
    public void ProcesarPago(decimal amount)
    {
      Console.WriteLine($"[Tarjeta de Crédito] Pago procesado por: {amount:C}");
    }
  }
}
