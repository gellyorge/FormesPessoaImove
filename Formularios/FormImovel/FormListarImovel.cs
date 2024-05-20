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
    public partial class FormListarImovel : Form
    {
        public FormListarImovel()
        {
            InitializeComponent();
            carregarGradview();
        }

        private void dataGridListarImovel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListarImovel_Load(object sender, EventArgs e)
        {

        }
        void carregarGradview()
        {
            dataGridListarImovel.Columns.Add("Id", "Id");
            dataGridListarImovel.Columns.Add("Endereco", "Endereço");
            dataGridListarImovel.Columns.Add("Quartos", "Quartos");
            dataGridListarImovel.Columns.Add("Garagens", "Garagens");
            dataGridListarImovel.Columns.Add("Aluguel", "Aluguel");
            dataGridListarImovel.Columns.Add("PessoaId", "Pessoa ID");

            List<Imovel> imovellist = new ImovelDb().SelectAll();

            foreach (Imovel imovel in imovellist)
            {
                dataGridListarImovel.Rows.Add(imovel.Id, imovel.Endereco, imovel.Quartos, imovel.Garagens, imovel.Aluguel, imovel.PessoaId);
            }
        }

    }
}
