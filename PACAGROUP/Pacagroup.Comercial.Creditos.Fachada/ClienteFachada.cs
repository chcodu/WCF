using Pacagroup.Comercial.Creditos.Dominio;
using System;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.SQLRepositorio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;


namespace Pacagroup.Comercial.Creditos.Fachada
{
    public class ClienteFachada: IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Cliente GetCliente(string NumeroIdentificacion)
        {
            IClienteRepository instancia = new ClienteRepositorio();
            return instancia.GetCliente(NumeroIdentificacion);
        }
        public IEnumerable<Cliente> GetListClient()
        {
            IClienteRepository instancia = new ClienteRepositorio();
            return instancia.GetListClient();
        }


    }
}
