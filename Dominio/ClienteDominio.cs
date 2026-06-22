using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : InformacionContacto
    {
        public string TipoCliente { get; set; }
        public string Empresa { get; set; }
        public InformacionContacto Contacto { get; set; }

    }
}
