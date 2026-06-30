using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class OrdenTrabajo
    {
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public int MecanicoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFin { get; set; }
        public string Estado { get; set; }
        public string Total { get; set; }
    }
}
