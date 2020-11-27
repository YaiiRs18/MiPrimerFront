using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Tarjetas
    {
        public static ML.Response.TarjetasResponse GetNip(ML.Entities.Tarjetas tarjetas)
        {
            ML.Response.TarjetasResponse response = new ML.Response.TarjetasResponse();
            try
            {
                using (DL.BancoEntities context = new DL.BancoEntities())
                {
                    var logeo = context.GetNip(tarjetas.NoTarjeta, tarjetas.Nip).ToList();

                    if (logeo.Count>0)
                    {

                        
                        response.Code = 100;
                        response.Message = "Mapeo Exitoso";
                        response.TarjetasList = new List<ML.Entities.Tarjetas>();

                        foreach (var obj in logeo)
                        {
                            ML.Entities.Tarjetas TarjetasItem = new ML.Entities.Tarjetas();
                            TarjetasItem.IdTarjetas = obj.IdTarjeta;
                            TarjetasItem.NoCuenta = obj.NoCuenta;
                            TarjetasItem.NoTarjeta = obj.NoTarjeta;
                            TarjetasItem.Nip = obj.Nip;
                            TarjetasItem.Saldo = obj.Saldo;
                            TarjetasItem.Clientes = new ML.Entities.Clientes();
                            TarjetasItem.Clientes.IdClientes = obj.IdClientes;
                            response.TarjetasList.Add(TarjetasItem);
                        }
                        
                        return response;
                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "error al buscar";
                        response.TarjetasList = new List<ML.Entities.Tarjetas>();
                        return response;
                    }

                }



            }
            catch (Exception ex)
            {
                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.TarjetasList = new List<ML.Entities.Tarjetas>();
                return response;
            }



        }
        public static ML.Response.TarjetasResponse GetSaldo(ML.Entities.Tarjetas tarjetas)
        {

            ML.Response.TarjetasResponse response = new ML.Response.TarjetasResponse();
            try
            {
                using (DL.BancoEntities context = new DL.BancoEntities())
                {
                    var GetSal = context.GetSaldo(tarjetas.Saldo);
                    
                    if(GetSal != null)
                    {
                        response.Code = 100;
                        response.Message = "mapeo exitoso";
                        response.TarjetasList = new List<ML.Entities.Tarjetas>();

                        foreach (var obj in GetSal)
                        {

                            ML.Entities.Tarjetas TarjetasItem = new ML.Entities.Tarjetas();
                            TarjetasItem.Saldo = obj.GetValueOrDefault();
                            response.TarjetasList.Add(TarjetasItem);
                        }

                        return response;


                    }

                    else
                    {
                        response.Code = 50;
                        response.Message = "no se encontro saldo";
                        response.TarjetasList = new List<ML.Entities.Tarjetas>();
                        return response;
                    }
                }



            }
            catch (Exception ex)
            {
                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.TarjetasList = new List<ML.Entities.Tarjetas>();
                return response;
            }


        }
        public static ML.Response.TarjetasResponse UpdateRe(ML.Entities.Tarjetas tarjetas)
        {
            ML.Response.TarjetasResponse response = new ML.Response.TarjetasResponse();
            try
            {
                using (DL.BancoEntities context = new DL.BancoEntities()) 
                {
                    var UpdateRe = context.RetiroSaldo(tarjetas.NoTarjeta, tarjetas.Saldo);

                    if (UpdateRe > 0)
                    {
                        response.Code = 100;
                        response.Message = "Retiro exitoso";
                        response.TarjetasList = new List<ML.Entities.Tarjetas>();
                        return response;



                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "error al retirar";
                        response.TarjetasList = new List<ML.Entities.Tarjetas>();
                        return response;
                    }

                }

            }
            catch (Exception ex )
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.TarjetasList = new List<ML.Entities.Tarjetas>();
                return response;
            }


        }

    }
}
