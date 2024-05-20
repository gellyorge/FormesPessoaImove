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

namespace FormesPessoaImove.Formularios.FormPessoa
{
    public partial class FormeSelecionarPessoa : Form
    {
        public FormeSelecionarPessoa()
        {
            InitializeComponent();
            carregarPessoa();

        }
        public Pessoa _pessoaSelecionada { get; private set; }

        private void FormeSelecionarPessoa_Load(object sender, EventArgs e)
        {

        }
        void carregarPessoa()
        {
            List<Pessoa> listpessoa = new PessoaDb().SelectAll();

            foreach (Pessoa p in listpessoa)
            {
                comboSelecionar.Items.Add(p);
            }
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            _pessoaSelecionada = (Pessoa)comboSelecionar.SelectedItem;

            if (_pessoaSelecionada != null) {               
                DialogResult = DialogResult.OK;                
            }
            else
            {
                MessageBox.Show("Selecione uma Pessoa para proseguir!");
            }
            
            
        }
    }
}
