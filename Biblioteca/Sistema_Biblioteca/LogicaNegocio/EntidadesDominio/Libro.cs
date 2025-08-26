using LogicaNegocio.InterfacesDominio;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Libro : IValidable<Libro>
    {
        public int Id { get; set; }
        public TituloLibro Titulo { get; set; } //Lo voy a hacer VO, no tiene justamente porque, solo lo hago para refrescar memoria
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }
        public bool EstaDisponible { get; set; }

        protected Libro() { }

        public Libro(TituloLibro tituloLibro, string autor, int anioPublicacion, bool estaDisponible)
        {
            Titulo = tituloLibro;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            EstaDisponible = estaDisponible;
            Validate();
        }

        public void Validate()
        {
            /*if (Email == null) throw new ExcepcionesUsuario("El email es Obligatorio");

            if (Contrasenia == null) throw new ExcepcionesUsuario("La contraseña es obligatoria");*/
        }
    }
}
