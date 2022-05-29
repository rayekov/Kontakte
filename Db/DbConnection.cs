using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakte.Db
{
    
    public abstract class DbConnection
    {
        private readonly string connectionString;
        public DbConnection()
        {   //database connection string
            connectionString = "Server=(local);DataBase=Kontakte; Integrated Security=true";
        }
        // connects to database
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
