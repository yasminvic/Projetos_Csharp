using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContato.Forms.Data
{
    public class ConnectionMySql
    {
        public static String ConnectionString { get; set; }
        public static String Server { get; set; }
        public static String DataBase { get; set; }
        public static String User { get; set; }
        public static String Password { get; set; }

        public static MySqlConnection GetConnection()
        {
            //credenciais
            Server = "localhost";
            DataBase = "agenda";
            User = "root";
            Password = "gibi2016";
            ConnectionString = $"Persist Security Info=False;server={Server};database={DataBase};uid={User};server={Server};database={DataBase};uid={User};pwd='{Password}'";

            //realiza conexao
            var conexao = new MySqlConnection(ConnectionString);

            try
            {
                conexao.Open();
            }catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                throw;
            }

            return conexao;
        }
    }
}
