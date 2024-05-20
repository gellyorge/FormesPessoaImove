namespace FormesPessoaImove.Formularios.FormPessoa
{
    partial class FormeSelecionarPessoa
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
            button1 = new Button();
            comboSelecionar = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(96, 150);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Selecionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboSelecionar
            // 
            comboSelecionar.FormattingEnabled = true;
            comboSelecionar.Location = new Point(29, 89);
            comboSelecionar.Name = "comboSelecionar";
            comboSelecionar.Size = new Size(227, 28);
            comboSelecionar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 2;
            label1.Text = "Selecione a Pessoa";
            
            // 
            // FormeSelecionarPessoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 206);
            Controls.Add(label1);
            Controls.Add(comboSelecionar);
            Controls.Add(button1);
            Name = "FormeSelecionarPessoa";
            Text = "Selecionar Pessoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboSelecionar;
        private Label label1;
    }
}