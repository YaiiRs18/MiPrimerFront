using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Entities
{
    public class Tarjetas
    {
        public int IdTarjetas { get; set; }
        public int NoCuenta { get; set; }
        public int NoTarjeta { get; set; }
        public int Nip { get; set; }
        public int Saldo { get; set; }
        public ML.Entities.Clientes Clientes{ get; set; }
        

    }
}
