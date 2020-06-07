using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _50P.Software.Connect.MySql
{
    public class ConnectMySQL
    {
        private string database;
        private string server;
        private string userId;
        private string password;
        private string port;
        private string other;
        private string connection;
        public string Connection
        {
            get
            {
                return connection;
            }
        }
        public ConnectMySQL(string Server, string UserID, string Password)
        {
            server = "server=" + Server + ";";
            userId = "user id=" + UserID + ";";
            password = "password=" + Password + ";";
            connection = server + userId + password;
        }
        public void setDatabase(string Databse)
        {
            database = "database=" + Databse + ";";
            connection += database;
        }
        public void setPort(int Port)
        {
            port = "port=" + Port.ToString() + ";";
            connection += port;
        }
        public void setOther(string Other)
        {
            other = Other;
            connection += other;
        }
    }
}
