namespace Punto1.Personaje
{
  internal class Guerrero : Heroe
  {
    public Guerrero()
    {
      Clase = "Guerrero";
      Habilidades.Add("Ataque Pesado");
      Habilidades.Add("Defensa Fortificada");
      Habilidades.Add("Berserk");
      Apariencia.Add("Espada");
      Apariencia.Add("Escudo");
      Apariencia.Add("Armadura");
    }

    public override Heroe Clone()
    {
      var copia = (Guerrero)MemberwiseClone();
      copia.Habilidades = [.. Habilidades];
      copia.Apariencia = [.. Apariencia];
      return copia;
    }
  }
}