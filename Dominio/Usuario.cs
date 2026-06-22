using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario : InformacionContacto
    {
        public InformacionContacto Contacto { get; set; }
        public string  Password { get; set; }
        public string  Roll { get; set; }
        public string  Especialidad { get; set; }
        public bool Activo { get; set; }
    }
}
