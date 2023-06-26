using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente GetCliente(string NumeroDocumento);
        [OperationContract]
        IEnumerable<Cliente> GetListClient();
    }
}
