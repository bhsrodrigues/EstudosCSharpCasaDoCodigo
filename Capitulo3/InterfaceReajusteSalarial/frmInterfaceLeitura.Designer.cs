namespace InterfaceReajusteSalarial
{
    partial class frmInterfaceLeitura
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.gpboxLabels = new System.Windows.Forms.GroupBox();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
            this.lblValorSemReajuste = new System.Windows.Forms.Label();
            this.lblValorComReajuste = new System.Windows.Forms.Label();
            this.lblValorReajuste = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPercentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNovoSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opnDlgArquivoFuncionario = new System.Windows.Forms.OpenFileDialog();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.gpboxLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(341, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(359, 10);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(27, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // gpboxLabels
            // 
            this.gpboxLabels.Controls.Add(this.lblValorReajuste);
            this.gpboxLabels.Controls.Add(this.lblValorComReajuste);
            this.gpboxLabels.Controls.Add(this.lblValorSemReajuste);
            this.gpboxLabels.Controls.Add(this.lblPercentualReajuste);
            this.gpboxLabels.Controls.Add(this.lblTotalComReajuste);
            this.gpboxLabels.Controls.Add(this.lblTotalSemReajuste);
            this.gpboxLabels.Location = new System.Drawing.Point(12, 45);
            this.gpboxLabels.Name = "gpboxLabels";
            this.gpboxLabels.Size = new System.Drawing.Size(374, 54);
            this.gpboxLabels.TabIndex = 2;
            this.gpboxLabels.TabStop = false;
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.AutoSize = true;
            this.lblTotalComReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComReajuste.Location = new System.Drawing.Point(129, 15);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(112, 13);
            this.lblTotalComReajuste.TabIndex = 1;
            this.lblTotalComReajuste.Text = "Total com reajuste";
            // 
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.AutoSize = true;
            this.lblPercentualReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblPercentualReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualReajuste.Location = new System.Drawing.Point(251, 15);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(117, 13);
            this.lblPercentualReajuste.TabIndex = 2;
            this.lblPercentualReajuste.Text = "Percentual reajuste";
            // 
            // lblValorSemReajuste
            // 
            this.lblValorSemReajuste.AutoSize = true;
            this.lblValorSemReajuste.Location = new System.Drawing.Point(79, 36);
            this.lblValorSemReajuste.Name = "lblValorSemReajuste";
            this.lblValorSemReajuste.Size = new System.Drawing.Size(13, 13);
            this.lblValorSemReajuste.TabIndex = 3;
            this.lblValorSemReajuste.Text = "0";
            // 
            // lblValorComReajuste
            // 
            this.lblValorComReajuste.AutoSize = true;
            this.lblValorComReajuste.Location = new System.Drawing.Point(212, 36);
            this.lblValorComReajuste.Name = "lblValorComReajuste";
            this.lblValorComReajuste.Size = new System.Drawing.Size(13, 13);
            this.lblValorComReajuste.TabIndex = 4;
            this.lblValorComReajuste.Text = "0";
            // 
            // lblValorReajuste
            // 
            this.lblValorReajuste.AutoSize = true;
            this.lblValorReajuste.Location = new System.Drawing.Point(344, 36);
            this.lblValorReajuste.Name = "lblValorReajuste";
            this.lblValorReajuste.Size = new System.Drawing.Size(13, 13);
            this.lblValorReajuste.TabIndex = 5;
            this.lblValorReajuste.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCodigo,
            this.columnSalario,
            this.columnPercentual,
            this.columnNovoSalario});
            this.dataGridView1.Location = new System.Drawing.Point(13, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(373, 161);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnCodigo
            // 
            this.columnCodigo.FillWeight = 75F;
            this.columnCodigo.HeaderText = "Código";
            this.columnCodigo.Name = "columnCodigo";
            this.columnCodigo.ReadOnly = true;
            this.columnCodigo.Width = 75;
            // 
            // columnSalario
            // 
            this.columnSalario.FillWeight = 85F;
            this.columnSalario.HeaderText = "Salário";
            this.columnSalario.Name = "columnSalario";
            this.columnSalario.ReadOnly = true;
            this.columnSalario.Width = 85;
            // 
            // columnPercentual
            // 
            this.columnPercentual.FillWeight = 75F;
            this.columnPercentual.HeaderText = "Percentual";
            this.columnPercentual.Name = "columnPercentual";
            this.columnPercentual.ReadOnly = true;
            this.columnPercentual.Width = 75;
            // 
            // columnNovoSalario
            // 
            this.columnNovoSalario.FillWeight = 95F;
            this.columnNovoSalario.HeaderText = "Novo Salário";
            this.columnNovoSalario.Name = "columnNovoSalario";
            this.columnNovoSalario.ReadOnly = true;
            this.columnNovoSalario.Width = 95;
            // 
            // opnDlgArquivoFuncionario
            // 
            this.opnDlgArquivoFuncionario.DefaultExt = "*.txt:";
            this.opnDlgArquivoFuncionario.Filter = "Arquivos de texto (.txt)|*.txt";
            this.opnDlgArquivoFuncionario.Title = "Selecionar arquivo de salário";
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.AutoSize = true;
            this.lblTotalSemReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalSemReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(6, 15);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(111, 13);
            this.lblTotalSemReajuste.TabIndex = 0;
            this.lblTotalSemReajuste.Text = "Total sem reajuste";
            // 
            // frmInterfaceLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 277);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpboxLabels);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtPath);
            this.Name = "frmInterfaceLeitura";
            this.Text = "Leitura de arquivo para reajuste de salários";
            this.Load += new System.EventHandler(this.frmInterfaceLeitura_Load);
            this.gpboxLabels.ResumeLayout(false);
            this.gpboxLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.GroupBox gpboxLabels;
        private System.Windows.Forms.Label lblValorReajuste;
        private System.Windows.Forms.Label lblValorComReajuste;
        private System.Windows.Forms.Label lblValorSemReajuste;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPercentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNovoSalario;
        private System.Windows.Forms.OpenFileDialog opnDlgArquivoFuncionario;
        private System.Windows.Forms.Label lblTotalSemReajuste;
    }
}

