using LogicaNegocio.EntidadesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioLibro : IRepositorio<Libro>
    {
        void Add(Libro obj);
        void Update(Libro obj);
        Libro FindById(int id);
        IEnumerable<Libro> FindAll();
        void Remove(int id);
    }
}
