using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Paquete
    {

        public String nombre { get; set; }
        public String descripcion { get; set; }
        public int precio { get; set; }
        public DateTime fecha_ini { get; set; }
        public int duracion { get; set; }

        public Paquete(string nombre, string descripcion, int precio, DateTime fecha_ini, int duracion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.fecha_ini = fecha_ini;
            this.duracion = duracion;
        }

        public override string ToString()
        {
            return "Nombre -> " + nombre + " ,Precio -> " + precio;
        }
    }
}
