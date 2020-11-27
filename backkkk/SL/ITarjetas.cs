using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    [ServiceContract]
    public interface ITarjetas
    {



        [OperationContract]
        TarjetasResponse GetNip(ML.Entities.Tarjetas tarjetas);
        [OperationContract]
        TarjetasResponse GetSaldo(ML.Entities.Tarjetas tarjetas);
        [OperationContract]
        TarjetasResponse UpdateRe(ML.Entities.Tarjetas tarjetas);
        // TODO: agregue aquí sus operaciones de servicio
    }

    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITarjetas" en el código y en el archivo de configuración a la vez.
    [DataContract]
    public class TarjetasResponse
    {
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public List<ML.Entities.Tarjetas> TarjetasList { get; set; }
    }
}
