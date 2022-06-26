using PracticaWeb.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaWeb.Servicio.Servicios
{
    public interface ITipoAnimalServicio
    {
        List<TipoAnimal> ObtenerTodosLosTipos();
        void Insertar(TipoAnimal entidad);
    }
}
