using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojectTransaction
{
    class ConnexionBase
    {
       public void init ()
       {
            MySqlConnection databaseConnec = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");
       }

    }
}
