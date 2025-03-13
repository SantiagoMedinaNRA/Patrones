namespace Punto2.Services
{
  class DeviceService : IObserver
  {
    private readonly string _deviceName;
    public DeviceService(string deviceName)
    {
      _deviceName = deviceName;
    }

    public void Update(string message)
    {
      Console.WriteLine($"[{_deviceName}] Nuevo mensaje recibido: {message}");
    }
  }
}
