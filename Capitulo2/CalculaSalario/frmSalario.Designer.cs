namespace CalculaSalario
{
    partial class frmSalario
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
            this.components = new System.ComponentModel.Container();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.grpboxTurno = new System.Windows.Forms.GroupBox();
            this.rdoNoturno = new System.Windows.Forms.RadioButton();
            this.rdobtnVespertino = new System.Windows.Forms.RadioButton();
            this.rdobtnMatutino = new System.Windows.Forms.RadioButton();
            this.grpboxCategoria = new System.Windows.Forms.GroupBox();
            this.radioVeterano = new System.Windows.Forms.RadioButton();
            this.rdobtnCalouro = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lstboxResult = new System.Windows.Forms.ListBox();
            this.toolTipSalario = new System.Windows.Forms.ToolTip(this.components);
            this.grpboxTurno.SuspendLayout();
            this.grpboxCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(11, 21);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(80, 13);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "&Salário Mínimo:";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(123, 18);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(78, 20);
            this.txtSalarioMinimo.TabIndex = 1;
            this.toolTipSalario.SetToolTip(this.txtSalarioMinimo, "Informe o valor do salário mínimo atual");
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(11, 45);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(100, 13);
            this.lblHoras.TabIndex = 2;
            this.lblHoras.Text = "&Horas Trabalhadas:";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(123, 45);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(78, 20);
            this.txtHoras.TabIndex = 3;
            // 
            // grpboxTurno
            // 
            this.grpboxTurno.Controls.Add(this.rdoNoturno);
            this.grpboxTurno.Controls.Add(this.rdobtnVespertino);
            this.grpboxTurno.Controls.Add(this.rdobtnMatutino);
            this.grpboxTurno.Location = new System.Drawing.Point(208, 12);
            this.grpboxTurno.Name = "grpboxTurno";
            this.grpboxTurno.Size = new System.Drawing.Size(90, 106);
            this.grpboxTurno.TabIndex = 4;
            this.grpboxTurno.TabStop = false;
            this.grpboxTurno.Text = "Turno";
            // 
            // rdoNoturno
            // 
            this.rdoNoturno.AutoSize = true;
            this.rdoNoturno.Location = new System.Drawing.Point(5, 77);
            this.rdoNoturno.Name = "rdoNoturno";
            this.rdoNoturno.Size = new System.Drawing.Size(63, 17);
            this.rdoNoturno.TabIndex = 2;
            this.rdoNoturno.TabStop = true;
            this.rdoNoturno.Text = "&Noturno";
            this.rdoNoturno.UseVisualStyleBackColor = true;
            // 
            // rdobtnVespertino
            // 
            this.rdobtnVespertino.AutoSize = true;
            this.rdobtnVespertino.Location = new System.Drawing.Point(6, 48);
            this.rdobtnVespertino.Name = "rdobtnVespertino";
            this.rdobtnVespertino.Size = new System.Drawing.Size(75, 17);
            this.rdobtnVespertino.TabIndex = 1;
            this.rdobtnVespertino.TabStop = true;
            this.rdobtnVespertino.Text = "Vesper&tino";
            this.rdobtnVespertino.UseVisualStyleBackColor = true;
            // 
            // rdobtnMatutino
            // 
            this.rdobtnMatutino.AutoSize = true;
            this.rdobtnMatutino.Location = new System.Drawing.Point(5, 19);
            this.rdobtnMatutino.Name = "rdobtnMatutino";
            this.rdobtnMatutino.Size = new System.Drawing.Size(66, 17);
            this.rdobtnMatutino.TabIndex = 0;
            this.rdobtnMatutino.TabStop = true;
            this.rdobtnMatutino.Text = "&Matutino";
            this.rdobtnMatutino.UseVisualStyleBackColor = true;
            // 
            // grpboxCategoria
            // 
            this.grpboxCategoria.Controls.Add(this.radioVeterano);
            this.grpboxCategoria.Controls.Add(this.rdobtnCalouro);
            this.grpboxCategoria.Location = new System.Drawing.Point(12, 71);
            this.grpboxCategoria.Name = "grpboxCategoria";
            this.grpboxCategoria.Size = new System.Drawing.Size(189, 47);
            this.grpboxCategoria.TabIndex = 5;
            this.grpboxCategoria.TabStop = false;
            this.grpboxCategoria.Text = "Categoria";
            // 
            // radioVeterano
            // 
            this.radioVeterano.AutoSize = true;
            this.radioVeterano.Location = new System.Drawing.Point(111, 18);
            this.radioVeterano.Name = "radioVeterano";
            this.radioVeterano.Size = new System.Drawing.Size(68, 17);
            this.radioVeterano.TabIndex = 1;
            this.radioVeterano.Text = "&Veterano";
            this.radioVeterano.UseVisualStyleBackColor = true;
            // 
            // rdobtnCalouro
            // 
            this.rdobtnCalouro.AutoSize = true;
            this.rdobtnCalouro.Location = new System.Drawing.Point(11, 20);
            this.rdobtnCalouro.Name = "rdobtnCalouro";
            this.rdobtnCalouro.Size = new System.Drawing.Size(61, 17);
            this.rdobtnCalouro.TabIndex = 0;
            this.rdobtnCalouro.Text = "&Calouro";
            this.rdobtnCalouro.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(213, 232);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "C&alcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(14, 232);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(187, 20);
            this.txtStatus.TabIndex = 8;
            // 
            // lstboxResult
            // 
            this.lstboxResult.FormattingEnabled = true;
            this.lstboxResult.Location = new System.Drawing.Point(14, 124);
            this.lstboxResult.Name = "lstboxResult";
            this.lstboxResult.Size = new System.Drawing.Size(284, 95);
            this.lstboxResult.TabIndex = 9;
            // 
            // toolTipSalario
            // 
            this.toolTipSalario.IsBalloon = true;
            this.toolTipSalario.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSalario.ToolTipTitle = "Ajuda";
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 264);
            this.Controls.Add(this.lstboxResult);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpboxCategoria);
            this.Controls.Add(this.grpboxTurno);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmSalario";
            this.Text = "Form1";
            this.grpboxTurno.ResumeLayout(false);
            this.grpboxTurno.PerformLayout();
            this.grpboxCategoria.ResumeLayout(false);
            this.grpboxCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.GroupBox grpboxTurno;
        private System.Windows.Forms.RadioButton rdoNoturno;
        private System.Windows.Forms.RadioButton rdobtnVespertino;
        private System.Windows.Forms.RadioButton rdobtnMatutino;
        private System.Windows.Forms.GroupBox grpboxCategoria;
        private System.Windows.Forms.RadioButton radioVeterano;
        private System.Windows.Forms.RadioButton rdobtnCalouro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ListBox lstboxResult;
        private System.Windows.Forms.ToolTip toolTipSalario;
    }
}

