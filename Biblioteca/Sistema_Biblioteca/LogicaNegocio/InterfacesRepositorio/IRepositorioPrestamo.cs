using LogicaNegocio.EntidadesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioPrestamo:IRepositorio<Prestamo>
    {
        void Add(Prestamo obj);
        void Update(Prestamo obj);
        Prestamo FindById(int id);
        IEnumerable<Prestamo> FindAll();
        void Remove(int id);
    }
}
