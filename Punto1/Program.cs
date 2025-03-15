using Punto1.Personaje;

namespace Punto1
{
  internal class Program
  {
    private static void Main()
    {
      Heroe guerreroOriginal = new Guerrero
      {
        Nombre = "Conan",
        Nivel = 5,
        Experiencia = 1000,
        PuntosHabilidad = 10
      };

      // Clonar el guerrero
      Heroe guerreroClonado1 = guerreroOriginal.Clone();
      guerreroClonado1.Personalizar("Roberick Black", ["Pelo negro", "Ojos marrones"]);

      // Clonar el héroe
      Heroe guerreroClonad02 = guerreroOriginal.Clone();
      guerreroClonad02.Habilidades.Add("Doble Empuñadura");
      guerreroClonad02.Personalizar("Anastasia Black", ["Pelo plateado", "Ojos azules"]);

      // Mostrar información de los héroes
      Console.WriteLine("Guerrero Original:");
      guerreroOriginal.MostrarInformacion();

      Console.WriteLine("\nGuerrero Clonado1:");
      guerreroClonado1.MostrarInformacion();

      Console.WriteLine("\nGuerrero Clonado2:");
      guerreroClonad02.MostrarInformacion();

      Console.WriteLine("");
      Heroe magoOriginal = new Mago
      {
        Nombre = "Gandalf The White",
        Nivel = 20,
        Experiencia = 10000,
        PuntosHabilidad = 60
      };

      // Clonar el guerrero
      Heroe magoClonado1 = magoOriginal.Clone();
      magoClonado1.Personalizar("Sauron The Gray", ["Pelo negro", "Ojos rojos"]);

      // Clonar el héroe
      Heroe magoClonado2 = magoOriginal.Clone();
      magoClonado2.Habilidades.Add("Explosion");
      magoClonado2.Personalizar("Victoria The Red", ["Pelo escarlata", "Ojos negros"]);

      // Mostrar información de los héroes
      Console.WriteLine("Mago Original:");
      magoOriginal.MostrarInformacion();

      Console.WriteLine("\nMago Clonado1:");
      magoClonado1.MostrarInformacion();

      Console.WriteLine("\nMago Clonado2:");
      magoClonado2.MostrarInformacion();

      Console.WriteLine("");

      Heroe arqueroOriginal = new Arquero
      {
        Nombre = "Silvina",
        Nivel = 9,
        Experiencia = 4546,
        PuntosHabilidad = 98
      };

      // Clonar el guerrero
      Heroe arqueroClonado1 = arqueroOriginal.Clone();
      arqueroClonado1.Personalizar("Rob", ["Pelo amarillo", "Ojos marrones"]);

      // Clonar el héroe
      Heroe arqueroClonado2 = arqueroOriginal.Clone();
      arqueroClonado2.Habilidades.Add("Flecha plateada");
      arqueroClonado2.Personalizar("Ray Stall", ["Pelo plateado", "Ojos azules"]);

      // Mostrar información de los héroes
      Console.WriteLine("Arquero Original:");
      arqueroOriginal.MostrarInformacion();

      Console.WriteLine("\nArquero Clonado1:");
      arqueroClonado1.MostrarInformacion();

      Console.WriteLine("\nArquero Clonado2:");
      arqueroClonado2.MostrarInformacion();
    }
  }
}