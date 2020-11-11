namespace _100Bgw
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAvvia2 = new System.Windows.Forms.Button();
            this.btnFerma2 = new System.Windows.Forms.Button();
            this.btnAvvia100 = new System.Windows.Forms.Button();
            this.btnFerma100 = new System.Windows.Forms.Button();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.txtDisplay100 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAvvia2
            // 
            this.btnAvvia2.Location = new System.Drawing.Point(22, 39);
            this.btnAvvia2.Name = "btnAvvia2";
            this.btnAvvia2.Size = new System.Drawing.Size(75, 23);
            this.btnAvvia2.TabIndex = 0;
            this.btnAvvia2.Text = "Avvia 2";
            this.btnAvvia2.UseVisualStyleBackColor = true;
            this.btnAvvia2.Click += new System.EventHandler(this.btnAvvia2_Click);
            // 
            // btnFerma2
            // 
            this.btnFerma2.Location = new System.Drawing.Point(22, 68);
            this.btnFerma2.Name = "btnFerma2";
            this.btnFerma2.Size = new System.Drawing.Size(75, 23);
            this.btnFerma2.TabIndex = 1;
            this.btnFerma2.Text = "Ferma 2";
            this.btnFerma2.UseVisualStyleBackColor = true;
            this.btnFerma2.Click += new System.EventHandler(this.btnFerma2_Click);
            // 
            // btnAvvia100
            // 
            this.btnAvvia100.Location = new System.Drawing.Point(271, 39);
            this.btnAvvia100.Name = "btnAvvia100";
            this.btnAvvia100.Size = new System.Drawing.Size(75, 23);
            this.btnAvvia100.TabIndex = 2;
            this.btnAvvia100.Text = "Avvia 100";
            this.btnAvvia100.UseVisualStyleBackColor = true;
            this.btnAvvia100.Click += new System.EventHandler(this.btnAvvia100_Click);
            // 
            // btnFerma100
            // 
            this.btnFerma100.Location = new System.Drawing.Point(271, 68);
            this.btnFerma100.Name = "btnFerma100";
            this.btnFerma100.Size = new System.Drawing.Size(75, 23);
            this.btnFerma100.TabIndex = 3;
            this.btnFerma100.Text = "Ferma 100";
            this.btnFerma100.UseVisualStyleBackColor = true;
            this.btnFerma100.Click += new System.EventHandler(this.btnFerma100_Click);
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.Location = new System.Drawing.Point(103, 39);
            this.txtDisplay2.Multiline = true;
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(130, 307);
            this.txtDisplay2.TabIndex = 4;
            // 
            // txtDisplay100
            // 
            this.txtDisplay100.Location = new System.Drawing.Point(352, 39);
            this.txtDisplay100.Multiline = true;
            this.txtDisplay100.Name = "txtDisplay100";
            this.txtDisplay100.Size = new System.Drawing.Size(130, 307);
            this.txtDisplay100.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 388);
            this.Controls.Add(this.txtDisplay100);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.btnFerma100);
            this.Controls.Add(this.btnAvvia100);
            this.Controls.Add(this.btnFerma2);
            this.Controls.Add(this.btnAvvia2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvvia2;
        private System.Windows.Forms.Button btnFerma2;
        private System.Windows.Forms.Button btnAvvia100;
        private System.Windows.Forms.Button btnFerma100;
        private System.Windows.Forms.TextBox txtDisplay2;
        private System.Windows.Forms.TextBox txtDisplay100;
    }
}

