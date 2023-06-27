using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;


namespace Pacagroup.Comercial.Creditos.ContratoRepositorio
{
   public interface ICreditoRepositorio
    {
        IEnumerable<Credito> GetListCreditos();
        Credito RegiterCredito(Credito credito);
        Credito UpdateCredito(Credito credito);
        bool DeleteCredito(string idCredito);
    }
}
