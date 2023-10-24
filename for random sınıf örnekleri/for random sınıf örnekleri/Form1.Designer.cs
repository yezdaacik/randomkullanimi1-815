namespace for_random_sınıf_örnekleri
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
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNotlar
            // 
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.Location = new System.Drawing.Point(166, 49);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(147, 225);
            this.lbNotlar.TabIndex = 0;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(34, 49);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(99, 60);
            this.btnUret.TabIndex = 1;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 316);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lbNotlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Button btnUret;
    }
}

