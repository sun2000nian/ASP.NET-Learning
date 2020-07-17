using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class DatabaseService
    {
        private SqlConnection connection
        {
            get
            {
                return new SqlConnection();
            }
        }

        public async Task<AccountData> TestSELECT()
        {
            List<AccountData> accounts = new List<AccountData>();
            try
            {
                string cmd = "SELECT * FROM account";
                
            }
        }
    }
}
