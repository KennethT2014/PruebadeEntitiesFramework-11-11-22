using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadeEntitiesFramework_11_11_22
{
    public abstract class Repository
    {
        private string connectionString;
        public Repository()
        {
            connectionString = @"Data Source=KENNETH;Initial Catalog=Sistema;Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        protected List<SqlParameter> parameters;
        protected bool ExecuteNonQuery(string transSql)
        {
            using (var connection = GetConnection())
            {
                command.Connection = connection;
            }
        }
    }
}
