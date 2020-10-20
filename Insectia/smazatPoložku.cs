using System;
using System.Windows.Forms;

namespace Insectia
{
    partial class smazatPoložku : Form
    {
        Database db;
        Item items;
        Settings sett;
        public smazatPoložku(Item item, Database db = null)
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            items = item;
            this.db = db;
        }

        private void smazatPoložku_Load(object sender, EventArgs e)
        {
            sett = new Settings();
            comboBoxSeznam.Items.AddRange((sett.Database) ? db.SelectCategories() : items.GetCategories());
            tlSmazat.Enabled = false;
        }

        private void comboBoxSeznam_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPoložka.Items.Clear();
            comboBoxPoložka.Text = String.Empty;
            if (comboBoxSeznam.SelectedIndex < 0)
            {
                tlSmazat.Enabled = false;
            }
            else
            {
                tlSmazat.Enabled = true;
                comboBoxPoložka.Items.AddRange(items.GetItemsNames(comboBoxSeznam.Text));
            }
        }

        private void tlSmazat_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxSeznam.Text;
            string selectedItem = comboBoxPoložka.Text;
            if (sett.Database)
            {
                try
                {
                    items.DeleteItems(selectedCategory, selectedItem);
                }
                finally
                {
                    db.DeleteRecord(selectedItem, selectedCategory);
                }
            }
            else
            {
                items.DeleteItems(selectedCategory, selectedItem);
            }
            if (comboBoxPoložka.SelectedIndex > 0)
            {
                comboBoxPoložka.Items.RemoveAt(comboBoxPoložka.SelectedIndex);
                comboBoxPoložka.Text = String.Empty;
                if (comboBoxPoložka.Items.Count == 0)
                {
                    comboBoxSeznam.Items.RemoveAt(comboBoxSeznam.SelectedIndex);
                    comboBoxSeznam.Text = String.Empty;
                }
            }
            else
            {
                comboBoxPoložka.Items.Clear();
                comboBoxPoložka.Text = String.Empty;
                comboBoxSeznam.Items.RemoveAt(comboBoxSeznam.SelectedIndex);
                comboBoxSeznam.Text = String.Empty;
            }
        }

        private void smazatPoložku_FormClosed(object sender, FormClosedEventArgs e)
        {
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
