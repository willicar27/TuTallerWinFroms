using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalleOrden
    {
        public int OrdenTrabajo { get; set; }
        public int Servicio { get; set; }
        public String Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
    }
}
