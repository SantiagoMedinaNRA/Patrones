namespace Punto1.Personaje
{
  internal abstract class Heroe
  {
    public string Nombre { get; set; }
    public string Clase { get; protected set; }
    public int Nivel { get; set; }
    public int Experiencia { get; set; }
    public int PuntosHabilidad { get; set; }
    public List<string> Habilidades { get; set; }
    public List<string> Apariencia { get; set; }

    public Heroe()
    {
      Habilidades = [];
      Apariencia = [];
    }

    public abstract Heroe Clone();

    public void Personalizar(string nombre, List<string> values)
    {
      Nombre = nombre;
      Apariencia = values;
    }

    public void MostrarInformacion()
    {
      Console.WriteLine($"Nombre: {Nombre}, Clase: {Clase}, Nivel: {Nivel}, Experiencia: {Experiencia}, Puntos de Habilidad: {PuntosHabilidad}");
      Console.WriteLine("Aparariencia: " + string.Join(", ", Apariencia));
      Console.WriteLine("Habilidades: " + string.Join(", ", Habilidades));
    }
  }
}