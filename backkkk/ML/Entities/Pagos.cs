using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Entities
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public int Monto { get; set; }
        public string Referencia { get; set; }
        public ML.Entities.Servicios Servicios { get; set; }
    }
}
