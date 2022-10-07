using AgendaContato.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContato.Forms.Data
{
    public class Repository
    {
        public Contato contato { get; set; }
        public MySqlDataReader FetchAll(String comd)
        {
            MySqlConnection conexao = ConnectionMySql.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(comd, conexao);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //private const String SQL_INSERT_CONTATO = "INSERT INTO contato (nome, sobrenome, email, telefone) VALUES ('teste', 'teste', 'teste', 'teste')";
    }
}
