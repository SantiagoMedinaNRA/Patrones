namespace DecoracionHabiltacionesHotel.Implementacion.ServiciosAdicionales
{
    public class FloresFrescas : ServicioDecorador
    {
        public FloresFrescas(ServicioBase servicioBase) : base(servicioBase)
        {
        }

        public override string Agregar()
        {
            return " - Flores frescas";
        }
    }
}
