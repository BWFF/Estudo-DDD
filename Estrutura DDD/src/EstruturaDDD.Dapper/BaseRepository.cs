using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Dapper
{
    public class BaseRepository
    {
        public string BdConnectionString { get; }

        public BaseRepository(IConfiguration AppConfig)
        {
            BdConnectionString = AppConfig.GetConnectionString("BDSqlServer");
        }
    }
}
