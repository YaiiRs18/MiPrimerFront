using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Pagos
    {
        public static ML.Response.PagosResponse PagosAdd(ML.Entities.Pagos pagos)
        {
            ML.Response.PagosResponse response = new ML.Response.PagosResponse();
            try
            {
                using (DL.BancoEntities context = new DL.BancoEntities())
                {
                   
                    var PagosAdd = context.AddPago(pagos.Monto, pagos.Referencia, pagos.Servicios.IdServicios);

                    if (PagosAdd > 0)
                    {
                        response.Code = 100;
                        response.Message = "se agrego con exito";
                        response.PagosList = new List<ML.Entities.Pagos>();
                        return response;

                    }
                    else
                    {

                        response.Code = 50;
                        response.Message = "error al agregar";
                        response.PagosList = new List<ML.Entities.Pagos>();
                        return response;
                    }


                }


            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.PagosList = new List<ML.Entities.Pagos>();
                return response;
            }

        }


    }
}
