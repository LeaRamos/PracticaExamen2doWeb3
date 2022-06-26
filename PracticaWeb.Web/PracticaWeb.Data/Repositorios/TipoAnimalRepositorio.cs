using PracticaWeb.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaWeb.Data.Repositorios
{
    public class TipoAnimalRepositorio : BaseRepositorio, ITipoAnimalRepositorio
    {
        public TipoAnimalRepositorio(PracticaEFContext ctx) : base(ctx)
        {

        }

        public void Insertar(TipoAnimal entidad)
        {
           _Contexto.TipoAnimals.Add(entidad);
        }

        public List<TipoAnimal> ObtenerTodosLosTipos()
        {
           return _Contexto.TipoAnimals.ToList();
        }
    }
}
