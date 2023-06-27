using System;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.SQLRepositorio;

namespace Pacagroup.Comercial.Creditos.Fachada
{
    public class CreditoFachada : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool DeleteCredito(string idCredito)
        {
            ICreditoRepositorio instancia = new CreditosRepositorio();
            return instancia.DeleteCredito(idCredito);
        }

        public IEnumerable<Credito> GetListCreditos()
        {
            ICreditoRepositorio instancia = new CreditosRepositorio();
            return instancia.GetListCreditos();
        }

        public Credito RegiterCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditosRepositorio();
            return instancia.RegiterCredito(credito);
        }

        public Credito UpdateCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditosRepositorio();
            return instancia.UpdateCredito(credito);
        }
    }
}
