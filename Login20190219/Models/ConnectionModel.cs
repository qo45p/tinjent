using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login20190219.Models
{
    public class ConnectionModel
    {
        public string mssqlconn()
        {
            return "Server=localhost;Database=UserData;Trusted_Connection=True";
        }
    }
}