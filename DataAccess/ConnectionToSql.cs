using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Common;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        
        public ConnectionToSql()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Cnn"].ConnectionString;
        }
        
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }



}
