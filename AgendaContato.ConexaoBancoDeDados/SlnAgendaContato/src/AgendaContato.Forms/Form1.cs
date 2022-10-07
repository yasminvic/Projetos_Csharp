using AgendaContato.Forms.Data;
using AgendaContato.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContato.Forms
{
    public partial class Form1 : Form
    {
        public Repository ContatoRepository = new Repository();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                InsertBD();
                MessageBox.Show("Contato cadastrado !", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpar();
            }
            else
            {
                MessageBox.Show("Nem todos os campos foram preenchidos !", "Formulário Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region METODOS

        private bool VerificaCampos()
        {
            bool verifica = true;
            if (txtNome.Text.Equals(""))
            {
                verifica = false;
            }
            if (txtSbnome.Text.Equals(""))
            {
                verifica = false;
            }
            if (txtEmail.Text.Equals(""))
            {
                verifica = false;
            }
            if (txtTel.Text.Equals(""))
            {
                verifica = false;
            }

            return verifica;
        }

        private void InsertBD()
        {
            Contato contato = new Contato(txtNome.Text, txtSbnome.Text, txtEmail.Text, txtTel.Text);

            String cmdInsert = $"INSERT INTO contato (nome, sobrenome, email, telefone) VALUES ('{contato.Nome}'," +
                                                                                              $"'{contato.Sobrenome}', " +
                                                                                              $"'{contato.Email}', " +
                                                                                              $"'{contato.Telefone}');";
            var cmd = ContatoRepository.FetchAll(cmdInsert);
        }

        private void Limpar()
        {
            txtNome.Clear();
            txtSbnome.Clear();
            txtEmail.Clear();
            txtTel.Clear();
        }

        #endregion
  
    }
}
