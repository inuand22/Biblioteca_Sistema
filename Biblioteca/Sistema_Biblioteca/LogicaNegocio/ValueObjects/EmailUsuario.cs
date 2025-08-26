using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObjects
{
    public class EmailUsuario : IEquatable<EmailUsuario>
    {
        public string Valor { get; private set; }

        protected EmailUsuario() { }

        public EmailUsuario(string valor)
        {
            Valor = valor;
            Validate();
        }

        private void Validate()
        {
            Valor = Valor.Trim();
            if (string.IsNullOrEmpty(Valor))
            {
                //throw new ExcepcionesUsuario("El email no puede estar vacío.");
            }

            if (!Valor.Contains("@"))
            {
                //throw new ExcepcionesUsuario("El email debe contener un arroba (@).");
            }

            int indexAt = Valor.IndexOf("@");
            if (indexAt == -1 || !Valor.Substring(indexAt).Contains("."))
            {
                //throw new ExcepcionesUsuario("El email debe contener un punto (.) después del arroba.");
            }

            if (Valor.Contains(" "))
            {
                //throw new ExcepcionesUsuario("El email no puede contener espacios en blanco.");
            }
        }

        public bool Equals(EmailUsuario? other)
        {
            if (other != null)
            {
                return this.Valor == other.Valor;
            }
            return false;
        }
    }
}

