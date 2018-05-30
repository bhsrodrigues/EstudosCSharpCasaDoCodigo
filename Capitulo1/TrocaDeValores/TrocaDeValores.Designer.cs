namespace TrocaDeValores
{
    partial class TrocaDeValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocaDeValores));
            this.valor1 = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Location = new System.Drawing.Point(9, 15);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(43, 13);
            this.valor1.TabIndex = 0;
            this.valor1.Text = "Valor 1:";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(58, 12);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(56, 20);
            this.txtValue1.TabIndex = 1;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(132, 15);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(43, 13);
            this.lblValor2.TabIndex = 2;
            this.lblValor2.Text = "Valor 2:";
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(178, 12);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(59, 20);
            this.txtValue2.TabIndex = 3;
            // 
            // btnTrocar
            // 
            this.btnTrocar.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocar.Image")));
            this.btnTrocar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrocar.Location = new System.Drawing.Point(91, 38);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(84, 31);
            this.btnTrocar.TabIndex = 4;
            this.btnTrocar.Text = "   Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // TrocaDeValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 81);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.valor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TrocaDeValores";
            this.Text = "Troca De Valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valor1;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Button btnTrocar;
    }
}

