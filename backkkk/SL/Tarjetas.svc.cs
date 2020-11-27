using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ML.Entities;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Tarjetas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Tarjetas.svc o Tarjetas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Tarjetas : ITarjetas
    {
        public TarjetasResponse GetNip(ML.Entities.Tarjetas tarjetas)
        {
            ML.Response.TarjetasResponse request = BL.Tarjetas.GetNip(tarjetas);
            return new TarjetasResponse { Code = request.Code, Message = request.Message, TarjetasList= request.TarjetasList };
        }

        public TarjetasResponse GetSaldo(ML.Entities.Tarjetas tarjetas)
        {
            ML.Response.TarjetasResponse request = BL.Tarjetas.GetSaldo(tarjetas);
            return new TarjetasResponse { Code = request.Code, Message = request.Message, TarjetasList = request.TarjetasList };
        }

        public TarjetasResponse UpdateRe(ML.Entities.Tarjetas tarjetas)
        {
            ML.Response.TarjetasResponse request = BL.Tarjetas.UpdateRe(tarjetas);
            return new TarjetasResponse { Code = request.Code, Message = request.Message, TarjetasList = request.TarjetasList };
        }
    }
}
