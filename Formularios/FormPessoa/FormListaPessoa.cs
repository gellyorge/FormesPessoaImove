using FormesPessoaImove.Classes;
using FormesPessoaImove.ClassesDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormesPessoaImove.Formularios
{
    public partial class FormListaPessoa : Form
    {
        public FormListaPessoa()
        {
            InitializeComponent();
            InicializarDados();

        }

        private void InicializarDados()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Endereco", "Endereço");
            dataGridView1.Columns.Add("Email", "E-mail");

            List<Pessoa> listaPessoas = new PessoaDb().SelectAll();

            foreach (Pessoa p in listaPessoas)
            {
                dataGridView1.Rows.Add(p.Id, p.Nome, p.Endereco, p.Email);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListaPessoa_Load(object sender, EventArgs e)
        {

        }
    }
}
