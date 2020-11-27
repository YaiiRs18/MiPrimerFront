using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    [ServiceContract]
    public interface IPagos
    {



        [OperationContract]
        PagosResponse GetPagos(ML.Entities.Pagos pagos);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class PagosResponse
    {
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public List<ML.Entities.Pagos> PagosList { get; set; }
    }
}
