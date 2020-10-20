using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Insectia
{
    partial class editacePoložek : Form
    {
        class EditedItem
        {
            public int index { get; set; }
            public string name { get; set; }
            public string category { get; set; }
            public string content { get; set; }

            public EditedItem(int index, string name, string category, string content)
            {
                this.index = index;
                this.name = name;
                this.category = category;
                this.content = content;
            }
        }

        Item items;
        Database db;
        Settings sett = new Settings();
        List<EditedItem> editedItems = new List<EditedItem>();
        public editacePoložek(Item items, Database db = null)
        {
            InitializeComponent();
            this.items = items;
            this.db = db;
        }

        private void editacePoložek_Load(object sender, EventArgs e)
        {
            btnOK1.DialogResult = DialogResult.OK;
            Reload();
        }

        private void editacePoložek_FormClosing(object sender, FormClosingEventArgs e)
        {
            editedItems.Clear();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            if (!editedItems.Count.Equals(0))
            {
                foreach (EditedItem edited in editedItems)
                {
                    items.UpdateItem(edited.index, edited.name, edited.category, edited.content);
                }
                if (sett.Database && db != null)
                {
                    db.Save();
                }
            }
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            if (chbEditCategoryOnly1.Checked)
            {
                if (sett.Database && db != null)
                {
                    db.UpdateCategories(comboBoxPoložky1.Text, comboBoxKategorie1.Text);
                }
                else
                {
                    items.UpdateCategory(comboBoxPoložky1.Text, comboBoxKategorie1.Text);
                }
                ReloadCategories();
            }
            else
            {
                editedItems.Add(new EditedItem(comboBoxPoložky1.SelectedIndex, poleNazev1.Text, comboBoxKategorie1.Text, rtbObsah1.Text));
                if (sett.Database && db != null)
                {
                    Seznam i = items.GetItem(comboBoxPoložky1.SelectedIndex);
                    db.UpdateRecord(i.Nazev, i.Kategorie, poleNazev1.Text, comboBoxKategorie1.Text, rtbObsah1.Text);
                }
            }
        }

        private void comboBoxPoložky1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chbEditCategoryOnly1.Checked)
            {
                if (comboBoxPoložky1.SelectedIndex >= 0)
                {
                    comboBoxKategorie1.Text = comboBoxPoložky1.Text;
                }
            }
            else
            {
                if (comboBoxPoložky1.SelectedIndex >= 0)
                {
                    comboBoxKategorie1.Items.Clear();
                    comboBoxKategorie1.Items.AddRange((sett.Database) ? db.SelectCategories() : items.GetCategories());
                    Seznam item = items.GetItem(comboBoxPoložky1.SelectedIndex);
                    poleNazev1.Text = item.Nazev;
                    comboBoxKategorie1.Text = item.Kategorie;
                    rtbObsah1.Text = item.Obsah;
                }
            }
        }

        private void chbEditCategoryOnly1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEditCategoryOnly1.Checked)
            {
                poleNazev1.Text = rtbObsah1.Text = comboBoxKategorie1.Text = string.Empty;
                ReloadCategories();
                poleNazev1.Enabled = rtbObsah1.Enabled = false;
                comboBoxKategorie1.DropDownStyle = ComboBoxStyle.Simple;
                btnOK1.Enabled = false;
            }
            else
            {
                comboBoxKategorie1.Text = string.Empty;
                comboBoxKategorie1.DropDownStyle = ComboBoxStyle.DropDownList;
                poleNazev1.Enabled = rtbObsah1.Enabled = true;
                Reload();
                btnOK1.Enabled = true;
            }
        }

        private void Reload()
        {
            comboBoxPoložky1.Items.Clear();
            comboBoxKategorie1.Items.Clear();
            comboBoxPoložky1.Items.AddRange(items.GetItemList());
        }
        private void ReloadCategories()
        {
            comboBoxKategorie1.Text = string.Empty;
            comboBoxKategorie1.Items.Clear();
            comboBoxPoložky1.Items.Clear();
            comboBoxPoložky1.Items.AddRange((sett.Database) ? db.SelectCategories() : items.GetCategories());
        }
    }
}
