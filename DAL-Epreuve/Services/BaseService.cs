using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Epreuve.Services
{
    public abstract class BaseService
    {
        protected readonly string _connectionString;

        public BaseService(IConfiguration configuration, string dbname)
        {
            _connectionString = configuration.GetConnectionString(dbname) ?? throw new ArgumentException(nameof(dbname));
        }
    }
}
