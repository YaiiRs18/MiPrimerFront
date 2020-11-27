using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ML.Entities;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Pagos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Pagos.svc o Pagos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Pagos : IPagos
    {
        public PagosResponse GetPagos(ML.Entities.Pagos pagos)
        {
            ML.Response.PagosResponse Request = BL.Pagos.PagosAdd(pagos);
            return new PagosResponse { Code = Request.Code, Message = Request.Message, PagosList = Request.PagosList };
        }
    }
}
