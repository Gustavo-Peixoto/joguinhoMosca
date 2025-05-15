namespace joguinhoMosca
{
    partial class PersonagemCard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            picPerfil = new PictureBox();
            lblName = new Label();
            lblNivel = new Label();
            lblRaca = new Label();
            lblTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)picPerfil).BeginInit();
            SuspendLayout();
            // 
            // picPerfil
            // 
            picPerfil.Location = new Point(-1, 0);
            picPerfil.Name = "picPerfil";
            picPerfil.Size = new Size(90, 98);
            picPerfil.TabIndex = 0;
            picPerfil.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(109, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(213, 73);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(38, 15);
            lblNivel.TabIndex = 2;
            lblNivel.Text = "label1";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Location = new Point(124, 45);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(38, 15);
            lblRaca.TabIndex = 3;
            lblRaca.Text = "label1";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(199, 9);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(38, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "label1";
            // 
            // PersonagemCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTipo);
            Controls.Add(lblRaca);
            Controls.Add(lblNivel);
            Controls.Add(lblName);
            Controls.Add(picPerfil);
            Name = "PersonagemCard";
            Size = new Size(254, 98);
            ((System.ComponentModel.ISupportInitialize)picPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPerfil;
        private Label lblName;
        private Label lblNivel;
        private Label lblRaca;
        private Label lblTipo;
    }
}
