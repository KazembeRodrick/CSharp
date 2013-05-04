using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBManager
{
    abstract class DBManager
    {
        protected string _server_name = "localhost";
        protected int _port = 3306; protected string _password = string.Empty;

        public string DatabaseName { get; set; }
        public string UserId { get; set; }

        public string Password {
            set { this._password = value; }
        }

        public string ServerName
        {
            get { return this._server_name; }
            set { this._server_name = value; }
        }

        public abstract int Port { get; set; }
    }
}
