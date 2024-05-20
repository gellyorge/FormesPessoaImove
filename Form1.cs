using FormesPessoaImove.Classes;
using FormesPessoaImove.ClassesDb;
using FormesPessoaImove.Formularios;
using FormesPessoaImove.Formularios.FormImovel;
using FormesPessoaImove.Formularios.FormPessoa;


namespace FormesPessoaImove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPessoas();
            form.MdiParent = this;
                form.Show();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormListaPessoa().ShowDialog();
        }

        private void imovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormImoveis().ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imovelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormListarImovel().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pessoaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormeSelecionarPessoa formSelecionarPessoa = new FormeSelecionarPessoa();
            formSelecionarPessoa.ShowDialog();
            try
            {
                Pessoa pessoaSelecionada = formSelecionarPessoa._pessoaSelecionada;
                //MessageBox.Show(pessoaSelecionada.ToString());
                new PessoaDb().Delete(pessoaSelecionada);
                MessageBox.Show($"{pessoaSelecionada} Deletado com Sucesso!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Operação inválida OBJETO nao selecionado" +
                    $" ou Nao pode ser deletado pois esta Atribuido a um Imovel");
            }
        }

        private void imovelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormSelecionarImovel formSelecionarImovel = new FormSelecionarImovel();
            formSelecionarImovel.ShowDialog();
            try
            {
                Imovel imovelSelecionado = formSelecionarImovel._selecionarImovel;
                new ImovelDb().Delete(imovelSelecionado);
                MessageBox.Show($"Imovel Deletado com sucesso!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Operação inválida OBJETO nao selecionado" +
                    $" ");
            }
        }

        private void pessoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormeSelecionarPessoa formSelecionarPessoa = new FormeSelecionarPessoa();
            formSelecionarPessoa.ShowDialog();
            try
            {
                Pessoa selecionarPessoa = formSelecionarPessoa._pessoaSelecionada;
                new FormPessoas(selecionarPessoa).ShowDialog();
            }
            catch
            {
               
            }
        }

        private void imovelToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormSelecionarImovel formSelecionarImovel = new FormSelecionarImovel();
            formSelecionarImovel.ShowDialog();
            try {
                Imovel imovelSelecionado = formSelecionarImovel._selecionarImovel;
                new FormImoveis(imovelSelecionado).ShowDialog();

            }
            catch {
                
            }
        }
    }
}
