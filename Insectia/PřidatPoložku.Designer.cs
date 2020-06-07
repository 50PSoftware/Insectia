namespace Insectia
{
    partial class PřidatPoložku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PřidatPoložku));
            this.labelNázevPoložky = new System.Windows.Forms.Label();
            this.textBoxNázevPoložky = new System.Windows.Forms.TextBox();
            this.labelKategorie = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelObsah = new System.Windows.Forms.Label();
            this.poleObsah = new System.Windows.Forms.RichTextBox();
            this.tlPotvrdit = new System.Windows.Forms.Button();
            this.tlZrušit = new System.Windows.Forms.Button();
            this.tlPřidat2 = new System.Windows.Forms.Button();
            this.tlPřidat1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNázevPoložky
            // 
            this.labelNázevPoložky.AutoSize = true;
            this.labelNázevPoložky.Location = new System.Drawing.Point(12, 9);
            this.labelNázevPoložky.Name = "labelNázevPoložky";
            this.labelNázevPoložky.Size = new System.Drawing.Size(80, 13);
            this.labelNázevPoložky.TabIndex = 0;
            this.labelNázevPoložky.Text = "Název položky:";
            // 
            // textBoxNázevPoložky
            // 
            this.textBoxNázevPoložky.Location = new System.Drawing.Point(98, 6);
            this.textBoxNázevPoložky.Name = "textBoxNázevPoložky";
            this.textBoxNázevPoložky.Size = new System.Drawing.Size(259, 20);
            this.textBoxNázevPoložky.TabIndex = 1;
            // 
            // labelKategorie
            // 
            this.labelKategorie.AutoSize = true;
            this.labelKategorie.Location = new System.Drawing.Point(12, 35);
            this.labelKategorie.Name = "labelKategorie";
            this.labelKategorie.Size = new System.Drawing.Size(55, 13);
            this.labelKategorie.TabIndex = 2;
            this.labelKategorie.Text = "Kategorie:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // labelObsah
            // 
            this.labelObsah.AutoSize = true;
            this.labelObsah.Location = new System.Drawing.Point(13, 62);
            this.labelObsah.Name = "labelObsah";
            this.labelObsah.Size = new System.Drawing.Size(41, 13);
            this.labelObsah.TabIndex = 4;
            this.labelObsah.Text = "Obsah:";
            // 
            // poleObsah
            // 
            this.poleObsah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poleObsah.Location = new System.Drawing.Point(16, 78);
            this.poleObsah.Name = "poleObsah";
            this.poleObsah.Size = new System.Drawing.Size(341, 142);
            this.poleObsah.TabIndex = 5;
            this.poleObsah.Text = "";
            // 
            // tlPotvrdit
            // 
            this.tlPotvrdit.Location = new System.Drawing.Point(15, 227);
            this.tlPotvrdit.Name = "tlPotvrdit";
            this.tlPotvrdit.Size = new System.Drawing.Size(75, 23);
            this.tlPotvrdit.TabIndex = 7;
            this.tlPotvrdit.Text = "Potvrdit";
            this.tlPotvrdit.UseVisualStyleBackColor = true;
            this.tlPotvrdit.Click += new System.EventHandler(this.tlPotvrdit_Click);
            // 
            // tlZrušit
            // 
            this.tlZrušit.Location = new System.Drawing.Point(275, 227);
            this.tlZrušit.Name = "tlZrušit";
            this.tlZrušit.Size = new System.Drawing.Size(82, 23);
            this.tlZrušit.TabIndex = 8;
            this.tlZrušit.Text = "Zrušit";
            this.tlZrušit.UseVisualStyleBackColor = true;
            this.tlZrušit.Click += new System.EventHandler(this.tlZrušit_Click);
            // 
            // tlPřidat2
            // 
            this.tlPřidat2.Location = new System.Drawing.Point(96, 227);
            this.tlPřidat2.Name = "tlPřidat2";
            this.tlPřidat2.Size = new System.Drawing.Size(173, 23);
            this.tlPřidat2.TabIndex = 9;
            this.tlPřidat2.Text = "Přidat";
            this.tlPřidat2.UseVisualStyleBackColor = true;
            this.tlPřidat2.Click += new System.EventHandler(this.tlPřidat2_Click);
            // 
            // tlPřidat1
            // 
            this.tlPřidat1.Location = new System.Drawing.Point(225, 32);
            this.tlPřidat1.Name = "tlPřidat1";
            this.tlPřidat1.Size = new System.Drawing.Size(132, 23);
            this.tlPřidat1.TabIndex = 6;
            this.tlPřidat1.Text = "Přidat";
            this.tlPřidat1.UseVisualStyleBackColor = true;
            this.tlPřidat1.Click += new System.EventHandler(this.tlPřidat1_Click);
            // 
            // PřidatPoložku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 262);
            this.Controls.Add(this.tlPřidat2);
            this.Controls.Add(this.tlZrušit);
            this.Controls.Add(this.tlPotvrdit);
            this.Controls.Add(this.tlPřidat1);
            this.Controls.Add(this.poleObsah);
            this.Controls.Add(this.labelObsah);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelKategorie);
            this.Controls.Add(this.textBoxNázevPoložky);
            this.Controls.Add(this.labelNázevPoložky);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PřidatPoložku";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přidat položku";
            this.Load += new System.EventHandler(this.PřidatPoložku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNázevPoložky;
        private System.Windows.Forms.TextBox textBoxNázevPoložky;
        private System.Windows.Forms.Label labelKategorie;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelObsah;
        private System.Windows.Forms.RichTextBox poleObsah;
        private System.Windows.Forms.Button tlPotvrdit;
        private System.Windows.Forms.Button tlZrušit;
        private System.Windows.Forms.Button tlPřidat2;
        private System.Windows.Forms.Button tlPřidat1;
    }
}