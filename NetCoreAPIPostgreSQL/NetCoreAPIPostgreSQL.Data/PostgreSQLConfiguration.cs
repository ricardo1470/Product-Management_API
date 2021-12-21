using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIPostgreSQL.Data
{
    public class PostgreSQLConfiguration
    {
        public PostgreSQLConfiguration(string ConnectionString) => this.ConnectionString = ConnectionString;
)
        public string ConnectionString { get; set; }
    }
}
