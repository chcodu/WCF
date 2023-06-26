using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionRepositorio
{
    public class ConexionRepositorio
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CreditoDB"].ToString();
        }
    }
}
