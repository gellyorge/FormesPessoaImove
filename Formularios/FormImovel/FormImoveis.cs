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
    public partial class FormImoveis : Form
    {
        private bool _imovelUpdate =  false;
        private int _imovelId;
       
        public FormImoveis()
        {
            InitializeComponent();
            carregarComboIdPessoa();
            boxQuartos.KeyPress += new KeyPressEventHandler(boxQuartos_KeyPress);
            boxGaragens.KeyPress += new KeyPressEventHandler(boxGaragens_KeyPress);
            boxAluguel.KeyPress += new KeyPressEventHandler(boxAluguel_KeyPress);
        }
        public FormImoveis(Imovel i)
        {
            _imovelUpdate = true;
            InitializeComponent();
            carregarComboIdPessoa();
            boxQuartos.KeyPress += new KeyPressEventHandler(boxQuartos_KeyPress);
            boxGaragens.KeyPress += new KeyPressEventHandler(boxGaragens_KeyPress);
            boxAluguel.KeyPress += new KeyPressEventHandler(boxAluguel_KeyPress);

            _imovelId = i.Id;
            boxEndereco.Text = i.Endereco;
            boxQuartos.Text = i.Quartos.ToString();
            boxGaragens.Text = i.Garagens.ToString();
            boxAluguel.Text = i.Aluguel.ToString();
            Pessoa selecionada = new PessoaDb().SelectObjetoId(i.Id);
            comboIdPessoa.Text = selecionada.ToString();

        }
        void carregarComboIdPessoa()
        {
            List<Pessoa> listaPessoas = new PessoaDb().SelectAll();
            foreach (Pessoa p in listaPessoas)
            {
                comboIdPessoa.Items.Add(p);
            }

        }

        //botao responsavel por cadastrar o Imovel
        private void Cadastrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(boxEndereco.Text) ||
                string.IsNullOrEmpty(boxAluguel.Text) ||
                string.IsNullOrEmpty(boxQuartos.Text) ||
                string.IsNullOrEmpty(boxGaragens.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
              
                Pessoa pessoaSelecionada = (Pessoa)comboIdPessoa.SelectedItem;
                int? idPessoa = pessoaSelecionada?.Id;

                Imovel novoImovel = new Imovel(
                    boxEndereco.Text,
                    int.Parse(boxQuartos.Text),
                    int.Parse(boxGaragens.Text),
                    decimal.Parse(boxAluguel.Text),
                    idPessoa
                );

               
                if (_imovelUpdate == true)
                {
                    novoImovel.Id = _imovelId;
                    new ImovelDb().Update(novoImovel);
                }
                else
                {
                    new ImovelDb().Insert(novoImovel);
                }                

                MessageBox.Show("Imovel cadastrado com sucesso!");
                Close();
            }
        }

        private void boxQuartos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere pressionado não é um controle e não é um dígito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede que o caractere seja inserido no TextBox
            }

            // Limita o número de caracteres a 3
            if ((sender as TextBox).Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede que o caractere seja inserido no TextBox
            }
        }

        private void boxGaragens_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere pressionado não é um controle e não é um dígito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede que o caractere seja inserido no TextBox
            }

            // Limita o número de caracteres a 3
            if ((sender as TextBox).Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede que o caractere seja inserido no TextBox
            }
        }

        private void boxAluguel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {

                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {

                e.Handled = true;
            }
            if ((sender as TextBox).Text.Replace(",", "").Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.Contains(',') && (sender as TextBox).SelectionStart > (sender as TextBox).Text.IndexOf(',') && (sender as TextBox).Text.Substring((sender as TextBox).Text.IndexOf(',') + 1).Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void FormImovel_Load(object sender, EventArgs e)
        {

        }
    }
}
