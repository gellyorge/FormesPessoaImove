namespace FormesPessoaImove
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            peToolStripMenuItem = new ToolStripMenuItem();
            imovelToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            pessoaToolStripMenuItem = new ToolStripMenuItem();
            imovelToolStripMenuItem1 = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            pessoaToolStripMenuItem1 = new ToolStripMenuItem();
            imovelToolStripMenuItem3 = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            pessoaToolStripMenuItem2 = new ToolStripMenuItem();
            imovelToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, listarToolStripMenuItem, atualizarToolStripMenuItem, deletarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(710, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { peToolStripMenuItem, imovelToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(86, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // peToolStripMenuItem
            // 
            peToolStripMenuItem.Name = "peToolStripMenuItem";
            peToolStripMenuItem.Size = new Size(137, 26);
            peToolStripMenuItem.Text = "Pessoa";
            peToolStripMenuItem.Click += peToolStripMenuItem_Click;
            // 
            // imovelToolStripMenuItem
            // 
            imovelToolStripMenuItem.Name = "imovelToolStripMenuItem";
            imovelToolStripMenuItem.Size = new Size(137, 26);
            imovelToolStripMenuItem.Text = "Imovel";
            imovelToolStripMenuItem.Click += imovelToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pessoaToolStripMenuItem, imovelToolStripMenuItem1 });
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(58, 24);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // pessoaToolStripMenuItem
            // 
            pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            pessoaToolStripMenuItem.Size = new Size(137, 26);
            pessoaToolStripMenuItem.Text = "Pessoa";
            pessoaToolStripMenuItem.Click += pessoaToolStripMenuItem_Click;
            // 
            // imovelToolStripMenuItem1
            // 
            imovelToolStripMenuItem1.Name = "imovelToolStripMenuItem1";
            imovelToolStripMenuItem1.Size = new Size(137, 26);
            imovelToolStripMenuItem1.Text = "Imovel";
            imovelToolStripMenuItem1.Click += imovelToolStripMenuItem1_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pessoaToolStripMenuItem1, imovelToolStripMenuItem3 });
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            atualizarToolStripMenuItem.Size = new Size(62, 24);
            atualizarToolStripMenuItem.Text = "Editar";
            // 
            // pessoaToolStripMenuItem1
            // 
            pessoaToolStripMenuItem1.Name = "pessoaToolStripMenuItem1";
            pessoaToolStripMenuItem1.Size = new Size(137, 26);
            pessoaToolStripMenuItem1.Text = "Pessoa";
            pessoaToolStripMenuItem1.Click += pessoaToolStripMenuItem1_Click;
            // 
            // imovelToolStripMenuItem3
            // 
            imovelToolStripMenuItem3.Name = "imovelToolStripMenuItem3";
            imovelToolStripMenuItem3.Size = new Size(137, 26);
            imovelToolStripMenuItem3.Text = "Imovel";
            imovelToolStripMenuItem3.Click += imovelToolStripMenuItem3_Click;
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pessoaToolStripMenuItem2, imovelToolStripMenuItem2 });
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new Size(72, 24);
            deletarToolStripMenuItem.Text = "Deletar";
            // 
            // pessoaToolStripMenuItem2
            // 
            pessoaToolStripMenuItem2.Name = "pessoaToolStripMenuItem2";
            pessoaToolStripMenuItem2.Size = new Size(137, 26);
            pessoaToolStripMenuItem2.Text = "Pessoa";
            pessoaToolStripMenuItem2.Click += pessoaToolStripMenuItem2_Click;
            // 
            // imovelToolStripMenuItem2
            // 
            imovelToolStripMenuItem2.Name = "imovelToolStripMenuItem2";
            imovelToolStripMenuItem2.Size = new Size(137, 26);
            imovelToolStripMenuItem2.Text = "Imovel";
            imovelToolStripMenuItem2.Click += imovelToolStripMenuItem2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 459);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Cadastro de Pessoas/Imovel";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem peToolStripMenuItem;
        private ToolStripMenuItem imovelToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem pessoaToolStripMenuItem;
        private ToolStripMenuItem imovelToolStripMenuItem1;
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private ToolStripMenuItem pessoaToolStripMenuItem1;
        private ToolStripMenuItem deletarToolStripMenuItem;
        private ToolStripMenuItem pessoaToolStripMenuItem2;
        private ToolStripMenuItem imovelToolStripMenuItem2;
        private ToolStripMenuItem imovelToolStripMenuItem3;
    }
}
