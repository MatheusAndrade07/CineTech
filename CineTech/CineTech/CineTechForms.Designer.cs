namespace CineTech
{
    partial class CineTechForms
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
            this.pbCartazDoFilme = new System.Windows.Forms.PictureBox();
            this.pnlInformacoesDeUsuario = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNomeDeUsuario = new System.Windows.Forms.TextBox();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDigitarNome = new System.Windows.Forms.Label();
            this.lblDigitarIdade = new System.Windows.Forms.Label();
            this.cmbSelecionarFilme = new System.Windows.Forms.ComboBox();
            this.lblSelecionarFilme = new System.Windows.Forms.Label();
            this.btnAssistirFilme = new System.Windows.Forms.Button();
            this.btnSelecionarFilme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartazDoFilme)).BeginInit();
            this.pnlInformacoesDeUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCartazDoFilme
            // 
            this.pbCartazDoFilme.Location = new System.Drawing.Point(877, 134);
            this.pbCartazDoFilme.Name = "pbCartazDoFilme";
            this.pbCartazDoFilme.Size = new System.Drawing.Size(309, 416);
            this.pbCartazDoFilme.TabIndex = 0;
            this.pbCartazDoFilme.TabStop = false;
            // 
            // pnlInformacoesDeUsuario
            // 
            this.pnlInformacoesDeUsuario.Controls.Add(this.btnAssistirFilme);
            this.pnlInformacoesDeUsuario.Controls.Add(this.lblDigitarIdade);
            this.pnlInformacoesDeUsuario.Controls.Add(this.lblDigitarNome);
            this.pnlInformacoesDeUsuario.Controls.Add(this.mskDataNascimento);
            this.pnlInformacoesDeUsuario.Controls.Add(this.txtNomeDeUsuario);
            this.pnlInformacoesDeUsuario.Location = new System.Drawing.Point(52, 436);
            this.pnlInformacoesDeUsuario.Name = "pnlInformacoesDeUsuario";
            this.pnlInformacoesDeUsuario.Size = new System.Drawing.Size(477, 216);
            this.pnlInformacoesDeUsuario.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(61, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(256, 122);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Bem vindo \r\nao CineTech!";
            // 
            // txtNomeDeUsuario
            // 
            this.txtNomeDeUsuario.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNomeDeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeDeUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDeUsuario.Location = new System.Drawing.Point(20, 54);
            this.txtNomeDeUsuario.Name = "txtNomeDeUsuario";
            this.txtNomeDeUsuario.Size = new System.Drawing.Size(235, 26);
            this.txtNomeDeUsuario.TabIndex = 0;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mskDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataNascimento.Location = new System.Drawing.Point(20, 127);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(92, 26);
            this.mskDataNascimento.TabIndex = 1;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDigitarNome
            // 
            this.lblDigitarNome.AutoSize = true;
            this.lblDigitarNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitarNome.Location = new System.Drawing.Point(16, 18);
            this.lblDigitarNome.Name = "lblDigitarNome";
            this.lblDigitarNome.Size = new System.Drawing.Size(208, 22);
            this.lblDigitarNome.TabIndex = 2;
            this.lblDigitarNome.Text = "Digite seu nome abaixo";
            // 
            // lblDigitarIdade
            // 
            this.lblDigitarIdade.AutoSize = true;
            this.lblDigitarIdade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitarIdade.Location = new System.Drawing.Point(16, 92);
            this.lblDigitarIdade.Name = "lblDigitarIdade";
            this.lblDigitarIdade.Size = new System.Drawing.Size(264, 22);
            this.lblDigitarIdade.TabIndex = 3;
            this.lblDigitarIdade.Text = "Digite sua data de nascimento";
            // 
            // cmbSelecionarFilme
            // 
            this.cmbSelecionarFilme.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelecionarFilme.FormattingEnabled = true;
            this.cmbSelecionarFilme.Location = new System.Drawing.Point(72, 230);
            this.cmbSelecionarFilme.Name = "cmbSelecionarFilme";
            this.cmbSelecionarFilme.Size = new System.Drawing.Size(210, 32);
            this.cmbSelecionarFilme.TabIndex = 3;
            // 
            // lblSelecionarFilme
            // 
            this.lblSelecionarFilme.AutoSize = true;
            this.lblSelecionarFilme.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarFilme.Location = new System.Drawing.Point(68, 193);
            this.lblSelecionarFilme.Name = "lblSelecionarFilme";
            this.lblSelecionarFilme.Size = new System.Drawing.Size(243, 22);
            this.lblSelecionarFilme.TabIndex = 4;
            this.lblSelecionarFilme.Text = "Selecione seu filme abaixo!";
            // 
            // btnAssistirFilme
            // 
            this.btnAssistirFilme.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssistirFilme.Location = new System.Drawing.Point(20, 176);
            this.btnAssistirFilme.Name = "btnAssistirFilme";
            this.btnAssistirFilme.Size = new System.Drawing.Size(144, 37);
            this.btnAssistirFilme.TabIndex = 5;
            this.btnAssistirFilme.Text = "Assistir Agora!";
            this.btnAssistirFilme.UseVisualStyleBackColor = true;
            // 
            // btnSelecionarFilme
            // 
            this.btnSelecionarFilme.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarFilme.Location = new System.Drawing.Point(72, 285);
            this.btnSelecionarFilme.Name = "btnSelecionarFilme";
            this.btnSelecionarFilme.Size = new System.Drawing.Size(169, 39);
            this.btnSelecionarFilme.TabIndex = 6;
            this.btnSelecionarFilme.Text = "Selecionar Filme";
            this.btnSelecionarFilme.UseVisualStyleBackColor = true;
            // 
            // CineTechForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSelecionarFilme);
            this.Controls.Add(this.lblSelecionarFilme);
            this.Controls.Add(this.cmbSelecionarFilme);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlInformacoesDeUsuario);
            this.Controls.Add(this.pbCartazDoFilme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CineTechForms";
            this.Text = "CineTechForms";
            ((System.ComponentModel.ISupportInitialize)(this.pbCartazDoFilme)).EndInit();
            this.pnlInformacoesDeUsuario.ResumeLayout(false);
            this.pnlInformacoesDeUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCartazDoFilme;
        private System.Windows.Forms.Panel pnlInformacoesDeUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.TextBox txtNomeDeUsuario;
        private System.Windows.Forms.Label lblDigitarIdade;
        private System.Windows.Forms.Label lblDigitarNome;
        private System.Windows.Forms.Button btnAssistirFilme;
        private System.Windows.Forms.ComboBox cmbSelecionarFilme;
        private System.Windows.Forms.Label lblSelecionarFilme;
        private System.Windows.Forms.Button btnSelecionarFilme;
    }
}

