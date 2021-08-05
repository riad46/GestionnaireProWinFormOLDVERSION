using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Gestionnaire_Pro.DataBase.DataConnection
{
    public class GestionnaireProConnection
    {
        /// <summary>
        /// Return the Connection String depending on the name that you insert as param
        /// </summary>
        /// <param name="myConnectionStringName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string myConnectionStringName)
        {
            return ConfigurationManager.ConnectionStrings[myConnectionStringName].ConnectionString;
        }
    }
}
