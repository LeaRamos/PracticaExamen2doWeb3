using PracticaWeb.Data.Modelos;
using PracticaWeb.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaWeb.Servicio.Servicios
{
    public class TipoAnimalServicio : ITipoAnimalServicio
    {
        ITipoAnimalRepositorio _AnimalRepositorio;
        public TipoAnimalServicio(ITipoAnimalRepositorio AnimalRepositorio)
        {
            _AnimalRepositorio = AnimalRepositorio;
        }


        public void Insertar(TipoAnimal entidad)
        {
            _AnimalRepositorio.Insertar(entidad);
        }

        public List<TipoAnimal> ObtenerTodosLosTipos()
        {
           return _AnimalRepositorio.ObtenerTodosLosTipos();
        }
    }
}
