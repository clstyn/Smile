using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Smile
{
    public class _connection
    {
        private static string constring;
        private static NpgsqlConnection conn;

        public static NpgsqlConnection Conn { get => conn;}
        public static string Connstring { get => constring; }

        public void getConn(string username, string pass, string database)
        {
            constring = "Host=localhost;Port=5432;Username="+username+";Password="+pass+";Database="+database;
            conn = new NpgsqlConnection(constring);
        }
    }
}
