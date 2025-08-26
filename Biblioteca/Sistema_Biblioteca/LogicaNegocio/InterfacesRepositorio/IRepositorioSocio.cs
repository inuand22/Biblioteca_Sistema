using LogicaNegocio.EntidadesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioSocio : IRepositorio<Socio>
    {
        void Add(Socio obj);
        void Update(Socio obj);
        Socio FindById(int id);
        IEnumerable<Socio> FindAll();
        void Remove(int id);
    }
}
