using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System;

namespace Pacagroup.Comercial.Creditos.SQLRepositorio
{
    public class CreditosRepositorio : ICreditoRepositorio
    {
        public bool DeleteCredito(string idCredito)
        {
            ConexionRepositorio stringConnection = new ConexionRepositorio();
            using (IDbConnection conexion = new SqlConnection(stringConnection.GetConnectionString()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("IdCredito", idCredito); 
                int result = conexion.Execute("dbo.sp_elimina_creditos", param: parametros, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public IEnumerable<Credito> GetListCreditos()
        {
            ConexionRepositorio stringConnection = new ConexionRepositorio();
            using (IDbConnection conexion = new SqlConnection(stringConnection.GetConnectionString()))
            {
                conexion.Open();

                IEnumerable<Credito> collection = conexion.Query<Credito>("dbo.sp_lista_creditos", commandType: CommandType.StoredProcedure);
                return collection;
            }
        }

        public Credito RegiterCredito(Credito credito)
        {
            ConexionRepositorio stringConnection = new ConexionRepositorio();
            using (IDbConnection conexion = new SqlConnection(stringConnection.GetConnectionString()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("TipoCredito", credito.TipoCredito);
                parametros.Add("IdCliente", credito.IdCliente);
                parametros.Add("Fecha", credito.Fecha);
                parametros.Add("DiaPago", credito.DiaPago);
                parametros.Add("Monto", credito.Monto);
                parametros.Add("Tasa", credito.Tasa);
                parametros.Add("Comision", credito.Comision);
                parametros.Add("IdCredito", credito.IdCredito, DbType.Int32, ParameterDirection.Output);

                var result = conexion.ExecuteScalar("dbo.sp_crea_creditos", param: parametros, commandType: CommandType.StoredProcedure);
                var pIdCredito = parametros.Get<Int32>("IdCredito");
                credito.IdCredito = pIdCredito;

                return credito;
            }
        }

        public Credito UpdateCredito(Credito credito)
        {
            ConexionRepositorio stringConnection = new ConexionRepositorio();
            using (IDbConnection conexion = new SqlConnection(stringConnection.GetConnectionString()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("IdCredito", credito.IdCredito);
                parametros.Add("TipoCredito", credito.TipoCredito);
                parametros.Add("IdCliente", credito.IdCliente);
                parametros.Add("Fecha", credito.Fecha);
                parametros.Add("DiaPago", credito.DiaPago);
                parametros.Add("Monto", credito.Monto);
                parametros.Add("Tasa", credito.Tasa);
                parametros.Add("Comision", credito.Comision);

                int result = conexion.Execute("dbo.sp_actualiza_creditos", param: parametros, commandType: CommandType.StoredProcedure);

                return result > 0 ? credito: new Credito();
            }
        }
    }
}
