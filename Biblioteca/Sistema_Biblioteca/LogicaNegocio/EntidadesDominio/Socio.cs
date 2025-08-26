using LogicaNegocio.InterfacesDominio;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Socio : IValidable<Socio>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public EmailUsuario Email { get; set; }
        public TelefonoUsuario Telefono { get; set; }

        protected Socio() { }

        public Socio(string nombre, EmailUsuario email, TelefonoUsuario telefono)
        {
            Nombre = nombre;
            Email = email;
            Telefono = telefono;
            Validate();
        }

        public void Validate()
        {
            /*if (Email == null) throw new ExcepcionesUsuario("El email es Obligatorio");

            if (Contrasenia == null) throw new ExcepcionesUsuario("La contraseña es obligatoria");*/
        }
    }
}
