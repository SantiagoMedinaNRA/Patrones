namespace Punto1.Personaje
{
  internal class Arquero : Heroe
  {
    public Arquero()
    {
      Clase = "Arquero";
      Habilidades.Add("Disparo Preciso");
      Habilidades.Add("Evasion");
      Habilidades.Add("Triple Tiro");
      Apariencia.Add("Armadura de cuero");
      Apariencia.Add("Capucha");
      Apariencia.Add("Botas de cuero");
    }

    public override Heroe Clone()
    {
      var copia = (Arquero)MemberwiseClone();
      copia.Habilidades = [.. Habilidades];
      copia.Apariencia = [.. Apariencia];
      return copia;
    }
  }
}