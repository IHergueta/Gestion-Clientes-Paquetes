using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Cliente
    {

        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
        public int telefono { get; set; }
        public List<Paquete> paquetes_reservados { get; set; }
        public List<Paquete> paquetes_comprados { get; set; }

        public Cliente(string nombre, string apellido, string dni, int telefono, List<Paquete> paquetes_reservados, List<Paquete> paquetes_comprados)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.paquetes_reservados = paquetes_reservados;
            this.paquetes_comprados = paquetes_comprados;
        }

        public override string ToString()
        {
            return "Dni -> " + dni + " ,Nombre -> " + nombre;
        }



        public void CancelarPaquete(Paquete package)
        {

            paquetes_comprados.Remove(package);
        }

        public void ReservarPaquete(Paquete package)
        {

            paquetes_reservados.Add(package);

        }

        public void ComprarPaquete(Paquete package)
        {

            paquetes_comprados.Add(package);
        }


    }
}
