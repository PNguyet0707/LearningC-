using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Binding_Data
{
    internal class CConnection
    {
        public SqlCommand ConnectDatabase()
        {
            var conString = "Data Source=DESKTOP-COBOVKQ;Initial Catalog =BtFa11;Integrated Security=True";
            var connection = new SqlConnection(conString);
            var command = new SqlCommand();
            command.Connection = connection;

            return command;
        }
    }
}

