using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;


namespace Pacagroup.Comercial.Creditos.ContratoRepositorio
{
    public interface IClienteRepository
    {
        Cliente GetCliente(string NumeroDocumento);
        IEnumerable<Cliente> GetListClient();
    }
}
