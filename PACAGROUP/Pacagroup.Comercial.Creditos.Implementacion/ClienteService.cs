using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Fachada;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Implementacion
{

    public class ClienteService : IClienteService
    {
        public Cliente GetCliente(string NumeroDocumento)
        {
            try
            {
                using (ClienteFachada instancia = new ClienteFachada())
                {
                    return instancia.GetCliente(NumeroDocumento);
                }
            }
            catch (System.Exception ex)
            {

                throw new FaultException<Error>(new Error() { CodigoError = "10001", Description = "Excepcion administrada", Mensaje = ex.Message });
            }
        }
        public IEnumerable<Cliente> GetListClient()
        {
            using (ClienteFachada instancia = new ClienteFachada())
            {
                return instancia.GetListClient();
            }
        }
    }
}
