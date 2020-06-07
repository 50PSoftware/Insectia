namespace Insectia
{
    partial class smazatPoložku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(smazatPoložku));
            this.popisekSeznam1 = new System.Windows.Forms.Label();
            this.comboBoxSeznam = new System.Windows.Forms.ComboBox();
            this.popisekPoložka = new System.Windows.Forms.Label();
            this.comboBoxPoložka = new System.Windows.Forms.ComboBox();
            this.tlSmazat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisekSeznam1
            // 
            this.popisekSeznam1.AutoSize = true;
            this.popisekSeznam1.Location = new System.Drawing.Point(12, 9);
            this.popisekSeznam1.Name = "popisekSeznam1";
            this.popisekSeznam1.Size = new System.Drawing.Size(48, 13);
            this.popisekSeznam1.TabIndex = 0;
            this.popisekSeznam1.Text = "Seznam:";
            // 
            // comboBoxSeznam
            // 
            this.comboBoxSeznam.FormattingEnabled = true;
            this.comboBoxSeznam.Location = new System.Drawing.Point(66, 6);
            this.comboBoxSeznam.Name = "comboBoxSeznam";
            this.comboBoxSeznam.Size = new System.Drawing.Size(206, 21);
            this.comboBoxSeznam.TabIndex = 1;
            this.comboBoxSeznam.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeznam_SelectedIndexChanged);
            // 
            // popisekPoložka
            // 
            this.popisekPoložka.AutoSize = true;
            this.popisekPoložka.Location = new System.Drawing.Point(12, 36);
            this.popisekPoložka.Name = "popisekPoložka";
            this.popisekPoložka.Size = new System.Drawing.Size(48, 13);
            this.popisekPoložka.TabIndex = 2;
            this.popisekPoložka.Text = "Položka:";
            // 
            // comboBoxPoložka
            // 
            this.comboBoxPoložka.FormattingEnabled = true;
            this.comboBoxPoložka.Location = new System.Drawing.Point(66, 33);
            this.comboBoxPoložka.Name = "comboBoxPoložka";
            this.comboBoxPoložka.Size = new System.Drawing.Size(206, 21);
            this.comboBoxPoložka.TabIndex = 3;
            // 
            // tlSmazat
            // 
            this.tlSmazat.Location = new System.Drawing.Point(109, 60);
            this.tlSmazat.Name = "tlSmazat";
            this.tlSmazat.Size = new System.Drawing.Size(75, 23);
            this.tlSmazat.TabIndex = 4;
            this.tlSmazat.Text = "Smazat";
            this.tlSmazat.UseVisualStyleBackColor = true;
            this.tlSmazat.Click += new System.EventHandler(this.tlSmazat_Click);
            // 
            // smazatPoložku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.tlSmazat);
            this.Controls.Add(this.comboBoxPoložka);
            this.Controls.Add(this.popisekPoložka);
            this.Controls.Add(this.comboBoxSeznam);
            this.Controls.Add(this.popisekSeznam1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "smazatPoložku";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smazat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.smazatPoložku_FormClosed);
            this.Load += new System.EventHandler(this.smazatPoložku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekSeznam1;
        private System.Windows.Forms.ComboBox comboBoxSeznam;
        private System.Windows.Forms.Label popisekPoložka;
        private System.Windows.Forms.ComboBox comboBoxPoložka;
        private System.Windows.Forms.Button tlSmazat;
    }
}