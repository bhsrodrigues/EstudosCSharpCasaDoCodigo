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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 287);
            this.Controls.Add(this.txtConsumption);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.lblHouseNumber);
            this.Name = "Form1";
            this.Text = "Consumo de Energia de um Condomínio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtConsumption;
    }
}

