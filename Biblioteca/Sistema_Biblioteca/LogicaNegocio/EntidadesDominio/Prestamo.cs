using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Prestamo : IValidable<Prestamo>
    {
        public int Id { get; set; }

        public int LibroID { get; set; }
        public Libro Libro { get; set; }

        public int SocioID { get; set; }
        public Socio Socio { get; set; }

        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        protected Prestamo() { }

        public Prestamo(int libroID, int socioID, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            LibroID = libroID;
            SocioID = socioID;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Validate();
        }

        public void Validate()
        {
            /*if (Email == null) throw new ExcepcionesUsuario("El email es Obligatorio");

            if (Contrasenia == null) throw new ExcepcionesUsuario("La contraseña es obligatoria");*/
        }
    }
}
