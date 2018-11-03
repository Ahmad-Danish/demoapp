using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Azuredemoapp.Repository
{
    public class Envdata : IEnv
    {
        public string getDBEnvironment()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
            {                               
                return conn.Query<string>("SP_getDBEnv", null, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
            }
        }
    }
}