namespace FormesPessoaImove.Formularios.FormImovel
{
    partial class FormListarImovel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridListarImovel = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridListarImovel).BeginInit();
            SuspendLayout();
            // 
            // dataGridListarImovel
            // 
            dataGridListarImovel.AllowUserToAddRows = false;
            dataGridListarImovel.AllowUserToDeleteRows = false;
            dataGridListarImovel.AllowUserToOrderColumns = true;
            dataGridListarImovel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListarImovel.Dock = DockStyle.Fill;
            dataGridListarImovel.Location = new Point(0, 0);
            dataGridListarImovel.Name = "dataGridListarImovel";
            dataGridListarImovel.ReadOnly = true;
            dataGridListarImovel.RowHeadersWidth = 51;
            dataGridListarImovel.Size = new Size(800, 450);
            dataGridListarImovel.TabIndex = 0;
            dataGridListarImovel.CellContentClick += dataGridListarImovel_CellContentClick;
            // 
            // FormListarImovel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridListarImovel);
            Name = "FormListarImovel";
            Text = "FormListarImovel";
            Load += FormListarImovel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridListarImovel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridListarImovel;
    }
}