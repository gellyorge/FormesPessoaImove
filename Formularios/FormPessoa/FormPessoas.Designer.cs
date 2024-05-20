namespace FormesPessoaImove.Formularios
{
    partial class FormPessoas
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
            boxNome = new TextBox();
            boxEmail = new TextBox();
            boxEndereco = new TextBox();
            Cadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // boxNome
            // 
            boxNome.Location = new Point(90, 82);
            boxNome.Name = "boxNome";
            boxNome.Size = new Size(195, 27);
            boxNome.TabIndex = 0;
            // 
            // boxEmail
            // 
            boxEmail.Location = new Point(90, 115);
            boxEmail.Name = "boxEmail";
            boxEmail.Size = new Size(195, 27);
            boxEmail.TabIndex = 1;
            // 
            // boxEndereco
            // 
            boxEndereco.Location = new Point(90, 148);
            boxEndereco.Name = "boxEndereco";
            boxEndereco.Size = new Size(195, 27);
            boxEndereco.TabIndex = 2;
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(139, 181);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(94, 29);
            Cadastrar.TabIndex = 3;
            Cadastrar.Text = "Salvar";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 89);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 155);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Endereco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 122);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 26);
            label4.Name = "label4";
            label4.Size = new Size(236, 38);
            label4.TabIndex = 7;
            label4.Text = "Cadastrar Pessoa";
            // 
            // FormPessoas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 255);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cadastrar);
            Controls.Add(boxEndereco);
            Controls.Add(boxEmail);
            Controls.Add(boxNome);
            Name = "FormPessoas";
            Text = "FormPessoa";
            WindowState = FormWindowState.Maximized;
            Load += FormPessoa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxNome;
        private TextBox boxEmail;
        private TextBox boxEndereco;
        private Button Cadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}