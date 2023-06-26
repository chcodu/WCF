using System.Configuration;

namespace Pacagroup.Comercial.Creditos.SQLRepositorio
{
    public class ConexionRepositorio
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CreditoDB"].ToString();
        }
    }
}
