using DecoracionHabiltacionesHotel.Implementacion;
using DecoracionHabiltacionesHotel.Implementacion.ServiciosAdicionales;

while (true)
{
    Console.WriteLine("Bienvenido.....\n");

    Console.WriteLine("¿Que servicios adicionales desea incluir en su habitación?\n");

    Console.WriteLine("1. Vino");
    Console.WriteLine("2. Flores Frescas");
    Console.WriteLine("3. Chocolate Gourmet");

    Console.WriteLine("");

    Console.WriteLine("Por favor digite todos los servicios que desea incluir separedos con una coma (,)\n");

    List<string> serviciosAdicionales = Console.ReadLine().Split(",").ToList();

    Console.WriteLine("");

    Huesped huesped = new Huesped();
    Basico basico = new Basico();

    huesped.solicitud(basico);

    if (serviciosAdicionales.Count > 0)
        Console.WriteLine("Adicionalmente, el huesped agregó en su habitación: \n");

    foreach (string servicio in serviciosAdicionales)
    {
        if ("1".Equals(servicio))
            huesped.solicitud(new Vino(basico));
        if ("2".Equals(servicio))
            huesped.solicitud(new FloresFrescas(basico));
        if ("3".Equals(servicio))
            huesped.solicitud(new ChocolateGourmet(basico));
    }

    Console.WriteLine("");

    Console.ReadLine();
}
