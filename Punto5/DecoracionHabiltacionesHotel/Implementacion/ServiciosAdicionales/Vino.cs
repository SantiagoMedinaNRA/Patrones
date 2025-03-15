namespace DecoracionHabiltacionesHotel.Implementacion.ServiciosAdicionales
{
    public class Vino : ServicioDecorador
    {
        public Vino(ServicioBase servicioBase) : base(servicioBase)
        {
        }

        public override string Agregar()
        {
            return " - Vino";
        }
    }
}
