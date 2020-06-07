using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Insectia
{
    partial class PřidatPoložku : Form
    {
        Item items;
        Database db;
        List<string> kategorie = new List<string>();
        List<Seznam> novéPoložky = new List<Seznam>();
        Settings sett;
        public PřidatPoložku(Item item, Database db = null)
        {
            InitializeComponent();
            items = item;
            this.db = db;
        }

        private void PřidatPoložku_Load(object sender, EventArgs e)
        {
            sett = new Settings();
            if (sett.Database)
            {
                if (items.GetItemsList().Count.Equals(0))
                    db.FillTables();
                comboBox1.Items.AddRange(db.SelectCategories());
                kategorie.AddRange(db.SelectCategories());
            }
            else
            {
                comboBox1.Items.AddRange(items.GetCategories());
                kategorie.AddRange(items.GetCategories());
            }
            tlPotvrdit.DialogResult = DialogResult.OK;
            tlPřidat1.Enabled = false;
        }

        private void tlZrušit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0 || !comboBox1.Text.Equals(String.Empty))
            {
                int i = 0;
                bool je = false;
                if (kategorie.Count == 0)
                {
                    tlPřidat1.Enabled = true;
                }
                else
                    tlPřidat1.Enabled = false;
                while (i < kategorie.Count)
                {
                    if (comboBox1.Text == kategorie[i])
                    {
                        je = true;
                    }
                    if (je)
                    {
                        tlPřidat1.Enabled = false;
                    }
                    else
                        tlPřidat1.Enabled = true;
                    i++;
                }
            }
            else
            {
                tlPřidat1.Enabled = false;
            }
        }

        private void tlPřidat1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
            kategorie.Add(comboBox1.Text);
            if (sett.Database && db != null)
            {
                db.AddCategory(comboBox1.Text);
            }
            tlPřidat1.Enabled = false;
        }

        private void tlPřidat2_Click(object sender, EventArgs e)
        {
            if (textBoxNázevPoložky.Text != "" && poleObsah.Text != "" && comboBox1.Text != "")
            {
                novéPoložky.Add(new Seznam(textBoxNázevPoložky.Text, comboBox1.Text, poleObsah.Text));
                if (sett.Database)
                {
                    db.AddRecord(textBoxNázevPoložky.Text, comboBox1.Text, poleObsah.Text);
                }
                textBoxNázevPoložky.Text = poleObsah.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Pole jsou prázdná!!", "Pozor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tlPotvrdit_Click(object sender, EventArgs e)
        {
            foreach (Seznam it in novéPoložky)
            {
                items.AddItem(it);
            }
            if (sett.Database)
            {
                try
                {
                    db.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Databáze nemohla být aktualizována kvůli následujícím chybám:\n" + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
