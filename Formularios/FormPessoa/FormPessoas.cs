using FormesPessoaImove.Classes;
using FormesPessoaImove.ClassesDb;
using System;
using System.Windows.Forms;

namespace FormesPessoaImove.Formularios
{
    public partial class FormPessoas : Form
    {
        private bool edicao = false;
        private int _pessoaId;

        public FormPessoas()
        {
            InitializeComponent();
        }

        public FormPessoas(Pessoa p)
        {
            InitializeComponent();
            edicao = true;
            Pessoa pessoaUpdate = new Pessoa(p.Id,boxNome.Text, boxEmail.Text, boxEndereco.Text);
            _pessoaId = p.Id;
            boxNome.Text = p.Nome;
            boxEmail.Text = p.Email;
            boxEndereco.Text = p.Endereco;
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            var pessoaDb = new PessoaDb();

            if (edicao == true)
            {
                Pessoa pessoaUpdate = new Pessoa(_pessoaId,boxNome.Text, boxEmail.Text, boxEndereco.Text);
                //MessageBox.Show(pessoaUpdate.ToString());
                pessoaDb.Update(pessoaUpdate);
            }
            else
            {
                pessoaDb.Insert(new Pessoa(boxNome.Text, boxEmail.Text, boxEndereco.Text));
            }

            MessageBox.Show("Cadastrado com sucesso!");
            Close();
        }

        private void FormPessoa_Load(object sender, EventArgs e)
        {

        }
    }
}
