using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.SQLRepositorio;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace Pacagroup.Comercial.Creditos.SQLRepositorio
{
    public class ClienteRepositorio : IClienteRepository
    {
        public Cliente GetCliente(string NumeroDocumento)
        {
            ConexionRepositorio conexion = new ConexionRepositorio();
            using (IDbConnection instancia = new SqlConnection(conexion.GetConnectionString()))
            {
                instancia.Open();
                var parametros = new DynamicParameters();
                parametros.Add("pNumeroDocumento", NumeroDocumento);

                var cliente = instancia.QuerySingle<Cliente>
                    ("sp_consulta_clientes", param: parametros, commandType: CommandType.StoredProcedure);

                return cliente;
            }
        }

        public IEnumerable<Cliente> GetListClient()
        {
            ConexionRepositorio conexion = new ConexionRepositorio();
            using (IDbConnection instancia = new SqlConnection(conexion.GetConnectionString()))
            {
                instancia.Open();

                var cliente = instancia.Query<Cliente>
                    ("sp_lista_clientes", commandType: CommandType.StoredProcedure);

                return cliente;
            }
        }
    }
}
