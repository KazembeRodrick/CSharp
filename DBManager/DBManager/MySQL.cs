using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBManager
{
    class MySQL : DBManager
    {
        //overridden base method.
        public override int Port
        {
            get { return _port ;}
            set { _port = value;}
        }
    }
}
