namespace Punto1.Personaje
{
  internal class Mago : Heroe
  {
    public Mago()
    {
      Clase = "Mago";
      Habilidades.Add("Bola de Fuego");
      Habilidades.Add("Escudo Arcano");
      Habilidades.Add("Meditación");
      Apariencia.Add("Túnica");
      Apariencia.Add("Bastón");
      Apariencia.Add("Libro de Hechizos");
    }

    public override Heroe Clone()
    {
      var copia = (Mago)MemberwiseClone();
      copia.Habilidades = [.. Habilidades];
      copia.Apariencia = [.. Apariencia];
      return copia;
    }
  }
}