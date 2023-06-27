using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Fachada;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Implementacion
{
    public class CreditoService : ICreditoService
    {
        public bool DeleteCredito(string idCredito)
        {
            try
            {
                using (CreditoFachada instancia = new CreditoFachada())
                {
                    return instancia.DeleteCredito(idCredito);
                }
            }
            catch (System.Exception ex)
            {

                throw new FaultException<Error>(new Error() { CodigoError = "10001", Description = "Excepcion administrada", Mensaje = ex.Message });
            }
        }

    public IEnumerable<Credito> GetListCreditos()
    {
        try
        {
            using (CreditoFachada instancia = new CreditoFachada())
            {
                return instancia.GetListCreditos();
            }
        }
        catch (System.Exception ex)
        {

            throw new FaultException<Error>(new Error() { CodigoError = "10001", Description = "Excepcion administrada", Mensaje = ex.Message });
        }
    }

    public Credito RegiterCredito(Credito credito)
    {
        try
        {
            using (CreditoFachada instancia = new CreditoFachada())
            {
                return instancia.RegiterCredito(credito);
            }
        }
        catch (System.Exception ex)
        {

            throw new FaultException<Error>(new Error() { CodigoError = "10001", Description = "Excepcion administrada", Mensaje = ex.Message });
        }
    }

    public Credito UpdateCredito(Credito credito)
    {
        try
        {
            using (CreditoFachada instancia = new CreditoFachada())
            {
                return instancia.UpdateCredito(credito);
            }
        }
        catch (System.Exception ex)
        {

            throw new FaultException<Error>(new Error() { CodigoError = "10001", Description = "Excepcion administrada", Mensaje = ex.Message });
        }
    }
}
}
