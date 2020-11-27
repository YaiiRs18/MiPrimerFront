using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Response
{
    public class PagosResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<ML.Entities.Pagos> PagosList { get; set; }


    }
}
