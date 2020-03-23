namespace annuityrepayment
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCalcAndShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDarlehn = new System.Windows.Forms.TextBox();
            this.txtZinssatz = new System.Windows.Forms.TextBox();
            this.txtTilgung = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcAndShow
            // 
            this.btnCalcAndShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnCalcAndShow.Location = new System.Drawing.Point(12, 87);
            this.btnCalcAndShow.Name = "btnCalcAndShow";
            this.btnCalcAndShow.Size = new System.Drawing.Size(199, 23);
            this.btnCalcAndShow.TabIndex = 0;
            this.btnCalcAndShow.Text = "Berechnen und Anzeigen";
            this.btnCalcAndShow.UseVisualStyleBackColor = true;
            this.btnCalcAndShow.Click += new System.EventHandler(this.BtnCalcAndShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Darlehnssumme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zinssatz (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tilgung (%)";
            // 
            // txtDarlehn
            // 
            this.txtDarlehn.Location = new System.Drawing.Point(111, 10);
            this.txtDarlehn.Name = "txtDarlehn";
            this.txtDarlehn.Size = new System.Drawing.Size(100, 20);
            this.txtDarlehn.TabIndex = 4;
            // 
            // txtZinssatz
            // 
            this.txtZinssatz.Location = new System.Drawing.Point(111, 35);
            this.txtZinssatz.Name = "txtZinssatz";
            this.txtZinssatz.Size = new System.Drawing.Size(100, 20);
            this.txtZinssatz.TabIndex = 5;
            // 
            // txtTilgung
            // 
            this.txtTilgung.Location = new System.Drawing.Point(111, 61);
            this.txtTilgung.Name = "txtTilgung";
            this.txtTilgung.Size = new System.Drawing.Size(100, 20);
            this.txtTilgung.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.button2.Location = new System.Drawing.Point(76, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tutorial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 146);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTilgung);
            this.Controls.Add(this.txtZinssatz);
            this.Controls.Add(this.txtDarlehn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcAndShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Annuitätentilgung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcAndShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDarlehn;
        public System.Windows.Forms.TextBox txtZinssatz;
        public System.Windows.Forms.TextBox txtTilgung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

