using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class Clientes
    {
        public static ML.Response.ClientesResponse GetTarjeta(ML.Entities.Tarjetas tarjetas)
        {
            ML.Response.ClientesResponse response = new ML.Response.ClientesResponse();
            try
            {
                using (DL.BancoEntities context = new DL.BancoEntities())

                {
                    var GetTar = context.GetTarjeta(tarjetas.NoTarjeta);
                    if (GetTar != null)
                    {
                        response.Code = 100;
                        response.Message = "Mapeo Exitoso";
                        response.ClientesList = new List<ML.Entities.Clientes>();
                        foreach (var obj in GetTar)
                        {
                            ML.Entities.Clientes ClientesItem = new ML.Entities.Clientes();
                            ClientesItem.Nombre = obj.ToString();
                            response.ClientesList.Add(ClientesItem);

                        }

                        return response;
                    }

                    else
                    {
                        response.Code = 50;
                        response.Message = "no se encontraron datos";
                        response.ClientesList = new List<ML.Entities.Clientes>();
                        return response;
                    }

                }
            }
            catch (Exception ex)
            {
                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.ClientesList = new List<ML.Entities.Clientes>();
                return response;
            }
             

            

        }
            

    }
}
