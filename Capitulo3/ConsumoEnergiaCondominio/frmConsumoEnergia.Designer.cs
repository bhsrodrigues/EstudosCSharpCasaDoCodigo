namespace ConsumoEnergiaCondominio
{
    partial class Form1
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
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.txtConsumption = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Location = new System.Drawing.Point(10, 15);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(52, 13);
            this.lblHouseNumber.TabIndex = 0;
            this.lblHouseNumber.Text = "Nº Casa: ";
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(63, 12);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(35, 20);
            this.txtHouseNumber.TabIndex = 1;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(114, 15);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(54, 13);
            this.lblConsumo.TabIndex = 2;
            this.lblConsumo.Text = "Consumo:";
            // 
            // txtConsumption
            // 
            this.txtConsumption.Location = new System.Drawing.Point(170, 12);
            this.txtConsumption.Name = "txtConsumption";
            this.txtConsumption.Size = new System.Drawing.Size(72, 20);
            this.txtConsumption.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(263, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnHouse,
            this.columnConsumption,
            this.columnDiscount});
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(325, 185);
            this.dataGridView1.TabIndex = 5;
            // 
            // columnHouse
            // 
            this.columnHouse.HeaderText = "Casa";
            this.columnHouse.Name = "columnHouse";
            this.columnHouse.ReadOnly = true;
            this.columnHouse.Width = 94;
            // 
            // columnConsumption
            // 
            this.columnConsumption.HeaderText = "Consumo";
            this.columnConsumption.Name = "columnConsumption";
            this.columnConsumption.ReadOnly = true;
            this.columnConsumption.Width = 94;
            // 
            // columnDiscount
            // 
            this.columnDiscount.HeaderText = "Desconto";
            this.columnDiscount.Name = "columnDiscount";
            this.columnDiscount.ReadOnly = true;
            this.columnDiscount.Width = 94;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(13, 242);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(118, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Processar Dados";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(158, 247);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(164, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total de consumo sem desconto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 276);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConsumption);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.lblHouseNumber);
            this.Name = "Form1";
            this.Text = "Consumo de Energia de um Condomínio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtConsumption;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnConsumption;
        private System.Windows.Forms.DataGridViewButtonColumn columnDiscount;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblTotal;
    }
}

