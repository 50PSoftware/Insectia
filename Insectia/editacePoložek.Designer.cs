namespace Insectia
{
    partial class editacePoložek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editacePoložek));
            this.labelPolozky1 = new System.Windows.Forms.Label();
            this.comboBoxPoložky1 = new System.Windows.Forms.ComboBox();
            this.labelNazev1 = new System.Windows.Forms.Label();
            this.poleNazev1 = new System.Windows.Forms.TextBox();
            this.labelKategorie1 = new System.Windows.Forms.Label();
            this.comboBoxKategorie1 = new System.Windows.Forms.ComboBox();
            this.labelObsah1 = new System.Windows.Forms.Label();
            this.rtbObsah1 = new System.Windows.Forms.RichTextBox();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.chbEditCategoryOnly1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelPolozky1
            // 
            this.labelPolozky1.AutoSize = true;
            this.labelPolozky1.Location = new System.Drawing.Point(12, 20);
            this.labelPolozky1.Name = "labelPolozky1";
            this.labelPolozky1.Size = new System.Drawing.Size(47, 13);
            this.labelPolozky1.TabIndex = 1;
            this.labelPolozky1.Text = "Položky:";
            // 
            // comboBoxPoložky1
            // 
            this.comboBoxPoložky1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPoložky1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPoložky1.FormattingEnabled = true;
            this.comboBoxPoložky1.Location = new System.Drawing.Point(77, 17);
            this.comboBoxPoložky1.Name = "comboBoxPoložky1";
            this.comboBoxPoložky1.Size = new System.Drawing.Size(237, 21);
            this.comboBoxPoložky1.TabIndex = 2;
            this.comboBoxPoložky1.SelectedIndexChanged += new System.EventHandler(this.comboBoxPoložky1_SelectedIndexChanged);
            // 
            // labelNazev1
            // 
            this.labelNazev1.AutoSize = true;
            this.labelNazev1.Location = new System.Drawing.Point(12, 47);
            this.labelNazev1.Name = "labelNazev1";
            this.labelNazev1.Size = new System.Drawing.Size(41, 13);
            this.labelNazev1.TabIndex = 3;
            this.labelNazev1.Text = "Název:";
            // 
            // poleNazev1
            // 
            this.poleNazev1.Location = new System.Drawing.Point(77, 44);
            this.poleNazev1.Name = "poleNazev1";
            this.poleNazev1.Size = new System.Drawing.Size(237, 20);
            this.poleNazev1.TabIndex = 4;
            // 
            // labelKategorie1
            // 
            this.labelKategorie1.AutoSize = true;
            this.labelKategorie1.Location = new System.Drawing.Point(12, 73);
            this.labelKategorie1.Name = "labelKategorie1";
            this.labelKategorie1.Size = new System.Drawing.Size(55, 13);
            this.labelKategorie1.TabIndex = 5;
            this.labelKategorie1.Text = "Kategorie:";
            // 
            // comboBoxKategorie1
            // 
            this.comboBoxKategorie1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategorie1.FormattingEnabled = true;
            this.comboBoxKategorie1.Location = new System.Drawing.Point(77, 70);
            this.comboBoxKategorie1.Name = "comboBoxKategorie1";
            this.comboBoxKategorie1.Size = new System.Drawing.Size(125, 21);
            this.comboBoxKategorie1.TabIndex = 6;
            // 
            // labelObsah1
            // 
            this.labelObsah1.AutoSize = true;
            this.labelObsah1.Location = new System.Drawing.Point(12, 100);
            this.labelObsah1.Name = "labelObsah1";
            this.labelObsah1.Size = new System.Drawing.Size(41, 13);
            this.labelObsah1.TabIndex = 7;
            this.labelObsah1.Text = "Obsah:";
            // 
            // rtbObsah1
            // 
            this.rtbObsah1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbObsah1.Location = new System.Drawing.Point(77, 97);
            this.rtbObsah1.Name = "rtbObsah1";
            this.rtbObsah1.Size = new System.Drawing.Size(237, 143);
            this.rtbObsah1.TabIndex = 8;
            this.rtbObsah1.Text = "";
            // 
            // btnOK1
            // 
            this.btnOK1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK1.Location = new System.Drawing.Point(12, 256);
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(75, 23);
            this.btnOK1.TabIndex = 9;
            this.btnOK1.Text = "Potvrdit";
            this.btnOK1.UseVisualStyleBackColor = true;
            this.btnOK1.Click += new System.EventHandler(this.btnOK1_Click);
            // 
            // btnEdit1
            // 
            this.btnEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit1.Location = new System.Drawing.Point(93, 256);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(141, 23);
            this.btnEdit1.TabIndex = 10;
            this.btnEdit1.Text = "Upravit";
            this.btnEdit1.UseVisualStyleBackColor = true;
            this.btnEdit1.Click += new System.EventHandler(this.btnEdit1_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose1.Location = new System.Drawing.Point(240, 256);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(75, 23);
            this.btnClose1.TabIndex = 11;
            this.btnClose1.Text = "Zavřít";
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // chbEditCategoryOnly1
            // 
            this.chbEditCategoryOnly1.AutoSize = true;
            this.chbEditCategoryOnly1.Location = new System.Drawing.Point(208, 72);
            this.chbEditCategoryOnly1.Name = "chbEditCategoryOnly1";
            this.chbEditCategoryOnly1.Size = new System.Drawing.Size(106, 17);
            this.chbEditCategoryOnly1.TabIndex = 12;
            this.chbEditCategoryOnly1.Text = "Úprava kategorií";
            this.chbEditCategoryOnly1.UseVisualStyleBackColor = true;
            this.chbEditCategoryOnly1.CheckedChanged += new System.EventHandler(this.chbEditCategoryOnly1_CheckedChanged);
            // 
            // editacePoložek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 291);
            this.Controls.Add(this.chbEditCategoryOnly1);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.btnEdit1);
            this.Controls.Add(this.btnOK1);
            this.Controls.Add(this.rtbObsah1);
            this.Controls.Add(this.labelObsah1);
            this.Controls.Add(this.comboBoxKategorie1);
            this.Controls.Add(this.labelKategorie1);
            this.Controls.Add(this.poleNazev1);
            this.Controls.Add(this.labelNazev1);
            this.Controls.Add(this.comboBoxPoložky1);
            this.Controls.Add(this.labelPolozky1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editacePoložek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editacePoložek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.editacePoložek_FormClosing);
            this.Load += new System.EventHandler(this.editacePoložek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPolozky1;
        private System.Windows.Forms.ComboBox comboBoxPoložky1;
        private System.Windows.Forms.Label labelNazev1;
        private System.Windows.Forms.TextBox poleNazev1;
        private System.Windows.Forms.Label labelKategorie1;
        private System.Windows.Forms.ComboBox comboBoxKategorie1;
        private System.Windows.Forms.Label labelObsah1;
        private System.Windows.Forms.RichTextBox rtbObsah1;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.CheckBox chbEditCategoryOnly1;
    }
}