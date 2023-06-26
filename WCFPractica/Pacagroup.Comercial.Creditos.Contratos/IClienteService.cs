using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Contratos
{
    public interface IClienteService
    {
        [OperationContract]
        Cliente GetCliente(string NumeroDocumento);
        [OperationContract]
        IEnumerable<Cliente> GetClienteList();
    }
}
