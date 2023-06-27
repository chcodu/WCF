using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Pacagroup.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetCliente/{NumeroDocumento}", BodyStyle = WebMessageBodyStyle.Bare)]
        [FaultContract(typeof(Error))]
        Cliente GetCliente(string NumeroDocumento);
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetListClient", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Cliente> GetListClient();
    }
}
