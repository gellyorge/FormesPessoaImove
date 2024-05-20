namespace FormesPessoaImove.Formularios
{
    partial class FormImoveis
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
            label1 = new Label();
            boxEndereco = new TextBox();
            boxQuartos = new TextBox();
            boxGaragens = new TextBox();
            boxAluguel = new TextBox();
            comboIdPessoa = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Cadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 38);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Imovel";
            // 
            // boxEndereco
            // 
            boxEndereco.Location = new Point(107, 70);
            boxEndereco.Name = "boxEndereco";
            boxEndereco.Size = new Size(125, 27);
            boxEndereco.TabIndex = 1;
            // 
            // boxQuartos
            // 
            boxQuartos.Location = new Point(107, 103);
            boxQuartos.Name = "boxQuartos";
            boxQuartos.Size = new Size(125, 27);
            boxQuartos.TabIndex = 2;
            // 
            // boxGaragens
            // 
            boxGaragens.Location = new Point(107, 138);
            boxGaragens.Name = "boxGaragens";
            boxGaragens.Size = new Size(125, 27);
            boxGaragens.TabIndex = 3;
            // 
            // boxAluguel
            // 
            boxAluguel.Location = new Point(107, 171);
            boxAluguel.Name = "boxAluguel";
            boxAluguel.Size = new Size(125, 27);
            boxAluguel.TabIndex = 4;
            // 
            // comboIdPessoa
            // 
            comboIdPessoa.FormattingEnabled = true;
            comboIdPessoa.Location = new Point(348, 69);
            comboIdPessoa.Name = "comboIdPessoa";
            comboIdPessoa.Size = new Size(125, 28);
            comboIdPessoa.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 78);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 6;
            label2.Text = "Endereco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 110);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 7;
            label3.Text = "Quartos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 145);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 8;
            label4.Text = "Garagens";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 178);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "Aluguel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 78);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 10;
            label6.Text = "Alugado Para:";
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(339, 149);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(94, 29);
            Cadastrar.TabIndex = 11;
            Cadastrar.Text = "Salvar";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // FormImoveis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 269);
            Controls.Add(Cadastrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboIdPessoa);
            Controls.Add(boxAluguel);
            Controls.Add(boxGaragens);
            Controls.Add(boxQuartos);
            Controls.Add(boxEndereco);
            Controls.Add(label1);
            Name = "FormImoveis";
            Text = "FormImovel";
            Load += FormImovel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox boxEndereco;
        private TextBox boxQuartos;
        private TextBox boxGaragens;
        private TextBox boxAluguel;
        private ComboBox comboIdPessoa;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Cadastrar;
    }
}