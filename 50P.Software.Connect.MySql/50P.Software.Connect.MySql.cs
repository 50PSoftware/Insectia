using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _50P.Software.Connect.MySql
{
    public class ConnectMySQL
    {
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
            connection = $"server={Server};user id={UserID};password={Password};";
        }
        public void setDatabase(string Databse)
        {
            connection += $"database={Databse};";
        }
        public void setPort(int Port)
        {
            connection += $"port={Port};";
        }
        public void setOther(string Other)
        {
            connection += $"{Other}";
        }
    }
}
