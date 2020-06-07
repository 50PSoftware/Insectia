namespace Insectia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.DataContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NačístToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.organizacePoložekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatPoložkuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitPoložkyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatPoložkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.nastaveníToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ukončitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.popisekKategorie1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.popisekPolozky = new System.Windows.Forms.Label();
            this.poleObsah = new System.Windows.Forms.RichTextBox();
            this.listBoxNázev = new System.Windows.Forms.ListBox();
            this.DataContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.DataContextMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // DataContextMenuStrip
            // 
            this.DataContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NačístToolStripMenuItem,
            this.uložitToolStripMenuItem1,
            this.ExportToolStripMenuItem,
            this.toolStripSeparator4,
            this.organizacePoložekToolStripMenuItem});
            this.DataContextMenuStrip.Name = "DataContextMenuStrip";
            this.DataContextMenuStrip.OwnerItem = this.dataToolStripMenuItem1;
            this.DataContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.DataContextMenuStrip.ShowImageMargin = false;
            this.DataContextMenuStrip.Size = new System.Drawing.Size(156, 120);
            // 
            // NačístToolStripMenuItem
            // 
            this.NačístToolStripMenuItem.Name = "NačístToolStripMenuItem";
            this.NačístToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.NačístToolStripMenuItem.Text = "Načíst";
            this.NačístToolStripMenuItem.Click += new System.EventHandler(this.načístToolStripMenuItem1_Click);
            // 
            // uložitToolStripMenuItem1
            // 
            this.uložitToolStripMenuItem1.Name = "uložitToolStripMenuItem1";
            this.uložitToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.uložitToolStripMenuItem1.Text = "Uložit";
            this.uložitToolStripMenuItem1.Click += new System.EventHandler(this.uložitToolStripMenuItem1_Click);
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ExportToolStripMenuItem.Text = "Export";
            this.ExportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(152, 6);
            // 
            // organizacePoložekToolStripMenuItem
            // 
            this.organizacePoložekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatPoložkuToolStripMenuItem1,
            this.upravitPoložkyToolStripMenuItem1,
            this.smazatPoložkyToolStripMenuItem});
            this.organizacePoložekToolStripMenuItem.Name = "organizacePoložekToolStripMenuItem";
            this.organizacePoložekToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.organizacePoložekToolStripMenuItem.Text = "Organizace položek";
            // 
            // přidatPoložkuToolStripMenuItem1
            // 
            this.přidatPoložkuToolStripMenuItem1.Name = "přidatPoložkuToolStripMenuItem1";
            this.přidatPoložkuToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.přidatPoložkuToolStripMenuItem1.Text = "Přidat";
            this.přidatPoložkuToolStripMenuItem1.Click += new System.EventHandler(this.přidatPoložkuToolStripMenuItem_Click);
            // 
            // upravitPoložkyToolStripMenuItem1
            // 
            this.upravitPoložkyToolStripMenuItem1.Name = "upravitPoložkyToolStripMenuItem1";
            this.upravitPoložkyToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.upravitPoložkyToolStripMenuItem1.Text = "Upravit";
            this.upravitPoložkyToolStripMenuItem1.Click += new System.EventHandler(this.upravitPoložkyToolStripMenuItem_Click);
            // 
            // smazatPoložkyToolStripMenuItem
            // 
            this.smazatPoložkyToolStripMenuItem.Name = "smazatPoložkyToolStripMenuItem";
            this.smazatPoložkyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.smazatPoložkyToolStripMenuItem.Text = "Smazat";
            this.smazatPoložkyToolStripMenuItem.Click += new System.EventHandler(this.smazatToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem1
            // 
            this.dataToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dataToolStripMenuItem1.DropDown = this.DataContextMenuStrip;
            this.dataToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dataToolStripMenuItem1.Name = "dataToolStripMenuItem1";
            this.dataToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dataToolStripMenuItem1.Text = "Data";
            this.dataToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem1,
            this.toolStripSeparator3,
            this.nastaveníToolStripMenuItem1,
            this.toolStripSeparator5,
            this.ukončitToolStripMenuItem1});
            this.menuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.ShowShortcutKeys = false;
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // nastaveníToolStripMenuItem1
            // 
            this.nastaveníToolStripMenuItem1.Name = "nastaveníToolStripMenuItem1";
            this.nastaveníToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.nastaveníToolStripMenuItem1.Text = "Nastavení";
            this.nastaveníToolStripMenuItem1.Click += new System.EventHandler(this.nastaveníToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // ukončitToolStripMenuItem1
            // 
            this.ukončitToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ukončitToolStripMenuItem1.Name = "ukončitToolStripMenuItem1";
            this.ukončitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ukončitToolStripMenuItem1.Text = "Ukončit";
            this.ukončitToolStripMenuItem1.Click += new System.EventHandler(this.ukončitToolStripMenuItem_Click);
            // 
            // popisekKategorie1
            // 
            this.popisekKategorie1.AutoSize = true;
            this.popisekKategorie1.Location = new System.Drawing.Point(9, 30);
            this.popisekKategorie1.Name = "popisekKategorie1";
            this.popisekKategorie1.Size = new System.Drawing.Size(55, 13);
            this.popisekKategorie1.TabIndex = 2;
            this.popisekKategorie1.Text = "Kategorie:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // popisekPolozky
            // 
            this.popisekPolozky.AutoSize = true;
            this.popisekPolozky.Location = new System.Drawing.Point(13, 58);
            this.popisekPolozky.Name = "popisekPolozky";
            this.popisekPolozky.Size = new System.Drawing.Size(47, 13);
            this.popisekPolozky.TabIndex = 5;
            this.popisekPolozky.Text = "Položky:";
            // 
            // poleObsah
            // 
            this.poleObsah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poleObsah.Location = new System.Drawing.Point(144, 81);
            this.poleObsah.Name = "poleObsah";
            this.poleObsah.Size = new System.Drawing.Size(128, 169);
            this.poleObsah.TabIndex = 6;
            this.poleObsah.Text = "";
            // 
            // listBoxNázev
            // 
            this.listBoxNázev.FormattingEnabled = true;
            this.listBoxNázev.Location = new System.Drawing.Point(12, 81);
            this.listBoxNázev.Name = "listBoxNázev";
            this.listBoxNázev.Size = new System.Drawing.Size(120, 173);
            this.listBoxNázev.TabIndex = 7;
            this.listBoxNázev.SelectedIndexChanged += new System.EventHandler(this.listBoxNázev_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBoxNázev);
            this.Controls.Add(this.poleObsah);
            this.Controls.Add(this.popisekPolozky);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.popisekKategorie1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DataContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label popisekKategorie1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label popisekPolozky;
        private System.Windows.Forms.RichTextBox poleObsah;
        private System.Windows.Forms.ListBox listBoxNázev;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip DataContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NačístToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem organizacePoložekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatPoložkuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem upravitPoložkyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smazatPoložkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
    }
}

