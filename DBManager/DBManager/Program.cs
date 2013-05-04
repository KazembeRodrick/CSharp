using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBManager
{
    class Program
    {
        static void Main(string[] args)
        {
            MySQL mysql = new MySQL();

            mysql.DatabaseName = "stock";
            mysql.UserId = "root";
            mysql.Password = "root";

            string config = "Server: " + mysql.ServerName + " DB: " + mysql.DatabaseName + " UID: " + mysql.UserId;
            Console.WriteLine(config);
            Console.Read();
        }
    }
}
