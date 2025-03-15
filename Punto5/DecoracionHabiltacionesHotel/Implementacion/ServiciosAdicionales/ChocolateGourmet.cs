namespace DecoracionHabiltacionesHotel.Implementacion.ServiciosAdicionales
{
    public class ChocolateGourmet : ServicioDecorador
    {
        public ChocolateGourmet(ServicioBase servicioBase) : base(servicioBase)
        {
        }

        public override string Agregar()
        {
            return " - Chocolate Gourmet";
            
        }
    }
}
