using PracticaWeb.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaWeb.Data.Repositorios
{
    public abstract class BaseRepositorio
    {
        protected PracticaEFContext _Contexto { get; set; }

        public BaseRepositorio(PracticaEFContext ctx)
        {
            _Contexto = ctx;
        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }
    }
}
