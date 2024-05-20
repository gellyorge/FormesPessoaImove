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

namespace FormesPessoaImove.Formularios.FormImovel
{
    public partial class FormSelecionarImovel : Form
    {
        public FormSelecionarImovel()
        {
            InitializeComponent();
            CarregarImovel();
        }
        public Imovel _selecionarImovel {  get; private set; } 
        private void button1_Click(object sender, EventArgs e)
        {
            if(CarregarImovel != null)
            {
                _selecionarImovel = (Imovel)comboBox1.SelectedItem;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Selecione um Imovel para prosseguir!");
            }

        }
        void CarregarImovel()
        {
            List<Imovel> listImovel = new ImovelDb().SelectAll();
            foreach (var i in listImovel) { 
                comboBox1.Items.Add(i);
            }
        }
    }
}
