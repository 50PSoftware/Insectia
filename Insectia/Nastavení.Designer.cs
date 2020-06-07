namespace Insectia
{
    partial class Nastavení
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nastavení));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxVytvořit1 = new System.Windows.Forms.CheckBox();
            this.comboBoxFileType1 = new System.Windows.Forms.ComboBox();
            this.radioButtonDatabáze = new System.Windows.Forms.RadioButton();
            this.radioButtonSoubor = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonUpřesnit = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.poleFilename = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxVytvořit1);
            this.groupBox1.Controls.Add(this.comboBoxFileType1);
            this.groupBox1.Controls.Add(this.radioButtonDatabáze);
            this.groupBox1.Controls.Add(this.radioButtonSoubor);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Úložiště dat";
            // 
            // checkBoxVytvořit1
            // 
            this.checkBoxVytvořit1.AutoSize = true;
            this.checkBoxVytvořit1.Location = new System.Drawing.Point(191, 45);
            this.checkBoxVytvořit1.Name = "checkBoxVytvořit1";
            this.checkBoxVytvořit1.Size = new System.Drawing.Size(62, 17);
            this.checkBoxVytvořit1.TabIndex = 3;
            this.checkBoxVytvořit1.Text = "Vytvořit";
            this.checkBoxVytvořit1.UseVisualStyleBackColor = true;
            // 
            // comboBoxFileType1
            // 
            this.comboBoxFileType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileType1.FormattingEnabled = true;
            this.comboBoxFileType1.Location = new System.Drawing.Point(107, 18);
            this.comboBoxFileType1.Name = "comboBoxFileType1";
            this.comboBoxFileType1.Size = new System.Drawing.Size(146, 21);
            this.comboBoxFileType1.TabIndex = 2;
            this.comboBoxFileType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileType1_SelectedIndexChanged);
            // 
            // radioButtonDatabáze
            // 
            this.radioButtonDatabáze.AutoSize = true;
            this.radioButtonDatabáze.Location = new System.Drawing.Point(6, 42);
            this.radioButtonDatabáze.Name = "radioButtonDatabáze";
            this.radioButtonDatabáze.Size = new System.Drawing.Size(83, 17);
            this.radioButtonDatabáze.TabIndex = 1;
            this.radioButtonDatabáze.TabStop = true;
            this.radioButtonDatabáze.Text = "Databázové";
            this.radioButtonDatabáze.UseVisualStyleBackColor = true;
            this.radioButtonDatabáze.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // radioButtonSoubor
            // 
            this.radioButtonSoubor.AutoSize = true;
            this.radioButtonSoubor.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSoubor.Name = "radioButtonSoubor";
            this.radioButtonSoubor.Size = new System.Drawing.Size(77, 17);
            this.radioButtonSoubor.TabIndex = 0;
            this.radioButtonSoubor.TabStop = true;
            this.radioButtonSoubor.Text = "Souborové";
            this.radioButtonSoubor.UseVisualStyleBackColor = true;
            this.radioButtonSoubor.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 114);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "Potvrdit";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonUpřesnit
            // 
            this.buttonUpřesnit.Location = new System.Drawing.Point(197, 114);
            this.buttonUpřesnit.Name = "buttonUpřesnit";
            this.buttonUpřesnit.Size = new System.Drawing.Size(75, 23);
            this.buttonUpřesnit.TabIndex = 2;
            this.buttonUpřesnit.Text = "Upřesnit";
            this.buttonUpřesnit.UseVisualStyleBackColor = true;
            this.buttonUpřesnit.Click += new System.EventHandler(this.buttonUpřesnit_Click);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(93, 114);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(98, 23);
            this.buttonDefault.TabIndex = 3;
            this.buttonDefault.Text = "Výchozí";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // poleFilename
            // 
            this.poleFilename.Location = new System.Drawing.Point(13, 87);
            this.poleFilename.Name = "poleFilename";
            this.poleFilename.Size = new System.Drawing.Size(178, 20);
            this.poleFilename.TabIndex = 4;
            this.poleFilename.TextChanged += new System.EventHandler(this.poleFilename_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(197, 85);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 5;
            this.buttonBrowse.Text = "Procházet";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // Nastavení
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 145);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.poleFilename);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.buttonUpřesnit);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 184);
            this.MinimumSize = new System.Drawing.Size(300, 184);
            this.Name = "Nastavení";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nastavení";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Nastavení_FormClosed);
            this.Load += new System.EventHandler(this.Nastavení_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSoubor;
        private System.Windows.Forms.RadioButton radioButtonDatabáze;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonUpřesnit;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.TextBox poleFilename;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.CheckBox checkBoxVytvořit1;
        private System.Windows.Forms.ComboBox comboBoxFileType1;
    }
}