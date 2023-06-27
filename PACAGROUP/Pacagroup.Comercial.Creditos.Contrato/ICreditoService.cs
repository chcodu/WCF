using System.ServiceModel;
using System.ServiceModel.Web;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ComponentModel;

namespace Pacagroup.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface ICreditoService
    {
        [OperationContract]
        [Description("Servicio REST que permite listar los créditos")]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/getlistcredito", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Credito> GetListCreditos();
        [OperationContract]
        [Description("Servicio REST que permite registrar los créditos")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, Method = "POST" ,ResponseFormat = WebMessageFormat.Json, UriTemplate = "/registercredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito RegiterCredito(Credito credito);
        [OperationContract]
        [Description("Servicio REST que permite actualizar los créditos")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/updatecredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito UpdateCredito(Credito credito);
        [OperationContract]
        [Description("Servicio REST que permite eliminar los créditos")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/deletecredito/{idCredito}", BodyStyle = WebMessageBodyStyle.Bare)]
        bool DeleteCredito(string idCredito);
    }
}
