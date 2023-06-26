using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Fachada;

namespace Pacagroup.Comercial.Creditos.Implementacion
{

    public class ClienteService : IClienteService
    {
        public Cliente GetCliente(string NumeroDocumento)
        {
            using(ClienteFachada instancia = new ClienteFachada())
            {
                return instancia.GetCliente(NumeroDocumento);
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
