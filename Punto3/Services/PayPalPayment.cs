using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3.Services
{
  public class PayPalPayment : IPayment
  {
    public void ProcesarPago(decimal amount)
    {
      Console.WriteLine($"[PayPal] Pago procesado por: {amount:C}");
    }
  }
}
