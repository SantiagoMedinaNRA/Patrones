using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionHabiltacionesHotel.Implementacion
{
    public abstract class ServicioDecorador : ServicioBase
    {
        protected ServicioBase _servicioBase;
        public ServicioDecorador(ServicioBase servicioBase)
        {
            _servicioBase = servicioBase;
        }

        public override string Agregar()
        {
            if (_servicioBase != null)
                return $"Huesped requiere: {_servicioBase.Agregar()}";

            return string.Empty;
        }
    }
}
