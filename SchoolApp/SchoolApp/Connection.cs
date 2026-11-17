using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SchoolApp
{
    internal class Connection
    {
        public MySqlConnection ConnectionToSQL()
        {
            string strconnection = "Server=localhost;Database=pi_school;Uid=root;pwd=";
            MySqlConnection conn = new MySqlConnection(strconnection);
            return conn;
        }
    }
}
