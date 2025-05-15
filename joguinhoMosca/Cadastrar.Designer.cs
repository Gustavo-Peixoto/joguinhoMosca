namespace joguinhoMosca
{
    partial class Cadastrar
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
            txtNome = new TextBox();
            txtRaca = new TextBox();
            txtNivel = new TextBox();
            txtTipo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnImagem = new Button();
            btnCadastrar = new Button();
            pic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(187, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(187, 92);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(100, 23);
            txtRaca.TabIndex = 1;
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(187, 135);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(100, 23);
            txtNivel.TabIndex = 2;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(187, 50);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 58);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Tipo ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 100);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Raça";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 143);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Nivel";
            // 
            // btnImagem
            // 
            btnImagem.Location = new Point(345, 121);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(74, 26);
            btnImagem.TabIndex = 8;
            btnImagem.Text = "button1";
            btnImagem.UseVisualStyleBackColor = true;
            btnImagem.Click += btnImagem_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(198, 174);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(78, 24);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "button2";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // pic
            // 
            pic.Location = new Point(319, 3);
            pic.Name = "pic";
            pic.Size = new Size(119, 112);
            pic.TabIndex = 11;
            pic.TabStop = false;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(pic);
            Controls.Add(btnCadastrar);
            Controls.Add(btnImagem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTipo);
            Controls.Add(txtNivel);
            Controls.Add(txtRaca);
            Controls.Add(txtNome);
            Name = "Cadastrar";
            Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtRaca;
        private TextBox txtNivel;
        private TextBox txtTipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnImagem;
        private Button btnCadastrar;
        private PictureBox pic;
    }
}