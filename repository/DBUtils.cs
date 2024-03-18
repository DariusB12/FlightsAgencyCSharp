using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using log4net;

namespace ProjectCS.repository
{
    public static class DBUtils
    {
		
        private static readonly ILog log = LogManager.GetLogger("DBUtils");

        private static IDbConnection instance = null;


        public static IDbConnection getConnection(IDictionary<string,string> props)
        {
            log.Info("Checking if exists a connection");
            if (instance == null || instance.State == System.Data.ConnectionState.Closed)
            {
                instance = getNewConnection(props);
                instance.Open();
            }
            return instance;
        }

        private static IDbConnection getNewConnection(IDictionary<string,string> props)
        {
            log.Info("Creating a new connection...");
            
            String connectionStringSqLite = props["connectionString"];
            Console.WriteLine("Sqlite ---se deschide o conexiune la: {0}", connectionStringSqLite);
            
            IDbConnection con = new SQLiteConnection(connectionStringSqLite);
            log.InfoFormat("A new connection was created: {0}",connectionStringSqLite);
            
            return con;
        }
    }
}