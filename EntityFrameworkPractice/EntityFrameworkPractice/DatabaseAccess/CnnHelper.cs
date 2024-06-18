using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace EntityFrameworkPractice.DatabaseAccess
{
    public class CnnHelper
    {
        public static string GetCnnString(string dbName)
        {
            return ConfigurationManager.ConnectionStrings[dbName].ConnectionString;   
        }
    }
}
