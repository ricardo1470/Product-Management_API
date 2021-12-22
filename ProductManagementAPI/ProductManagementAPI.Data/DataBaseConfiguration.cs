using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAPI.Data
{
    public class DataBaseConfiguration
    {
        public DataBaseConfiguration(string connectionString) => ConnectionString = connectionString;
        public string ConnectionString { get; set; }
    }
}
