using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año  { get; set; }

        public int Kilometro { get; set; }

        public string Motor { get; set; }
        public string UrlImagen { get; set; }
        public int IdCliente { get; set; }
    }
}
