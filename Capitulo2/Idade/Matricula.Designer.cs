namespace Idade
{
    partial class frmMatricula
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblUltimoAniversario = new System.Windows.Forms.Label();
            this.txtUltimoAniversario = new System.Windows.Forms.TextBox();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(346, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(12, 57);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(81, 51);
            this.dtpNascimento.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(80, 20);
            this.dtpNascimento.TabIndex = 3;
            this.dtpNascimento.Value = new System.DateTime(2018, 6, 4, 0, 0, 0, 0);
            // 
            // lblUltimoAniversario
            // 
            this.lblUltimoAniversario.AutoSize = true;
            this.lblUltimoAniversario.Location = new System.Drawing.Point(177, 57);
            this.lblUltimoAniversario.Name = "lblUltimoAniversario";
            this.lblUltimoAniversario.Size = new System.Drawing.Size(128, 13);
            this.lblUltimoAniversario.TabIndex = 4;
            this.lblUltimoAniversario.Text = "Ano do último aniversário:";
            // 
            // txtUltimoAniversario
            // 
            this.txtUltimoAniversario.Location = new System.Drawing.Point(311, 54);
            this.txtUltimoAniversario.Name = "txtUltimoAniversario";
            this.txtUltimoAniversario.Size = new System.Drawing.Size(103, 20);
            this.txtUltimoAniversario.TabIndex = 5;
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(15, 97);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(14, 13);
            this.lblDataAtual.TabIndex = 6;
            this.lblDataAtual.Text = "A";
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 122);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.txtUltimoAniversario);
            this.Controls.Add(this.lblUltimoAniversario);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmMatricula";
            this.Text = "Matrícula do Aluno";
            this.Load += new System.EventHandler(this.frmMatricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblUltimoAniversario;
        private System.Windows.Forms.TextBox txtUltimoAniversario;
        private System.Windows.Forms.Label lblDataAtual;
    }
}

