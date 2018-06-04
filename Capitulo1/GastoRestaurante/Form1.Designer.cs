namespace GastoRestaurante
{
    partial class frmGastoRestaurante
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
            this.lblDespesa = new System.Windows.Forms.Label();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.lblTotalPercentual = new System.Windows.Forms.Label();
            this.txtResultadoPercentual = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Location = new System.Drawing.Point(12, 20);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(49, 13);
            this.lblDespesa.TabIndex = 0;
            this.lblDespesa.Text = "Despesa";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Location = new System.Drawing.Point(67, 17);
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(82, 20);
            this.txtValorDespesa.TabIndex = 1;
            // 
            // lblTotalPercentual
            // 
            this.lblTotalPercentual.AutoSize = true;
            this.lblTotalPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPercentual.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalPercentual.Location = new System.Drawing.Point(11, 52);
            this.lblTotalPercentual.Name = "lblTotalPercentual";
            this.lblTotalPercentual.Size = new System.Drawing.Size(90, 13);
            this.lblTotalPercentual.TabIndex = 2;
            this.lblTotalPercentual.Text = "Total com 10%";
            // 
            // txtResultadoPercentual
            // 
            this.txtResultadoPercentual.BackColor = System.Drawing.Color.Yellow;
            this.txtResultadoPercentual.Enabled = false;
            this.txtResultadoPercentual.Location = new System.Drawing.Point(119, 49);
            this.txtResultadoPercentual.Name = "txtResultadoPercentual";
            this.txtResultadoPercentual.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoPercentual.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(155, 17);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(64, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmGastoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 101);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultadoPercentual);
            this.Controls.Add(this.lblTotalPercentual);
            this.Controls.Add(this.txtValorDespesa);
            this.Controls.Add(this.lblDespesa);
            this.Name = "frmGastoRestaurante";
            this.Text = "Gasto em restaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.Label lblTotalPercentual;
        private System.Windows.Forms.TextBox txtResultadoPercentual;
        private System.Windows.Forms.Button btnCalcular;
    }
}

