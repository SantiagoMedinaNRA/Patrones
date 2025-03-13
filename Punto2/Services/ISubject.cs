namespace Punto2.Services
{
  interface ISubject
  {
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message);
  }
}