using System;
using System.Windows.Forms;

namespace Insectia
{
    partial class Form1 : Form
    {
        Item items = new Item();
        Database db;
        FirstRunSetting settFR;
        Settings sett;
        ExportSettings exsett;

        //Files
        CSV csvFile;
        XML xmlFile;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settFR = new FirstRunSetting();
            sett = new Settings();
            exsett = new ExportSettings();
            notifyIcon1.Text = "Insetcia - Menu";
            if (settFR.FirstRun)
            {
                Nastavení oknoNastavení = new Nastavení();
                DialogResult Ans = oknoNastavení.ShowDialog();
                if (Ans == DialogResult.OK)
                {
                    if (sett.cestaKSouboru == String.Empty)
                        dataToolStripMenuItem1.Enabled = false;
                    else
                    {
                        dataToolStripMenuItem1.Enabled = true;
                        exsett.Reload();
                        sett.Reload();
                    }
                }
                else
                {
                    dataToolStripMenuItem1.Enabled = false;
                }
            }
            else
            {
                if (sett.cestaKSouboru == String.Empty)
                    dataToolStripMenuItem1.Enabled = false;
                else
                    dataToolStripMenuItem1.Enabled = true;
            }
            Text = "Insectia";
            notifyIcon1.ContextMenuStrip = DataContextMenuStrip;
            poleObsah.BorderStyle = BorderStyle.None;
            if (sett.Database)
            {
                _50P.Software.Connect.MySql.ConnectMySQL connect = new _50P.Software.Connect.MySql.ConnectMySQL(sett.server, sett.username, SecurePass.GetUnprotectedPassword(sett.password));
                connect.setDatabase(sett.dbname);
                db = new Database(connect.Connection);
            }
            if (sett.přípona == ".csv")
                csvFile = new CSV(sett.cestaKSouboru);
            else if (sett.přípona == ".xml")
                xmlFile = new XML(sett.cestaKSouboru);
            upravitPoložkyToolStripMenuItem1.Enabled = smazatPoložkyToolStripMenuItem.Enabled = uložitToolStripMenuItem1.Enabled = ExportToolStripMenuItem.Enabled = !items.GetItemsList().Count.Equals(0);
            uložitToolStripMenuItem1.Visible = !sett.Database;
            ExportToolStripMenuItem.Visible = exsett.remember;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sett.Save();
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nastaveníToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            listBoxNázev.Items.Clear();
            poleObsah.Text = comboBox1.Text = String.Empty;
            Nastavení oknoNastavení = new Nastavení();
            DialogResult odp = oknoNastavení.ShowDialog();
            if (odp == DialogResult.OK)
            {
                items.Clear();
                if (sett.cestaKSouboru == String.Empty)
                    dataToolStripMenuItem1.Enabled = false;
                else
                {
                    sett.Reload();
                    exsett.Reload();
                    dataToolStripMenuItem1.Enabled = true;
                    ExportToolStripMenuItem.Visible = exsett.remember;
                    if (!sett.Database)
                    {
                        if (sett.přípona == ".csv")
                        {
                            if(csvFile == null)
                            {
                                csvFile = new CSV(sett.cestaKSouboru);
                            }
                            else
                            {
                                csvFile.SetFilename(sett.cestaKSouboru);
                            }
                        }
                        else if (sett.přípona == ".xml")
                        {
                            if(xmlFile == null)
                            {
                                xmlFile = new XML(sett.cestaKSouboru);
                            }
                            else
                            {
                                xmlFile.SetFilename(sett.cestaKSouboru);
                            }
                        }
                    }
                    else
                    {
                        _50P.Software.Connect.MySql.ConnectMySQL connect = new _50P.Software.Connect.MySql.ConnectMySQL(sett.server, sett.username, SecurePass.GetUnprotectedPassword(sett.password));
                        connect.setDatabase(sett.dbname);
                        if (db == null)
                        {
                            db = new Database();
                        }
                        db.SetConnectionString(connect.Connection);
                    }
                }
            }
            else if(odp == DialogResult.Abort || odp == DialogResult.Retry)
            {
                dataToolStripMenuItem1.Enabled = false;
            }
            ReloadItems();
        }

        private void přidatPoložkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PřidatPoložku oknoOP = new PřidatPoložku(items, (sett.Database) ? db : null);
            if (oknoOP.ShowDialog() == DialogResult.OK)
            {
                ReloadItems();
            }
        }

        private void načístToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                listBoxNázev.Items.Clear();
                poleObsah.Text = String.Empty;
            }
            else
            {
                poleObsah.Text = String.Empty;
                listBoxNázev.Items.Clear();
                listBoxNázev.Items.AddRange(items.GetItemsNames(comboBox1.Text));
            }
        }

        private void listBoxNázev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNázev.SelectedIndex < 0)
            {
                poleObsah.Text = String.Empty;
            }
            else
            {
                poleObsah.Text = items.GetItemContent(comboBox1.Text, listBoxNázev.SelectedIndex);
            }
        }

        private void upravitPoložkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editacePoložek oknoEdit = new editacePoložek(items, (sett.Database) ? db : null);
            if (oknoEdit.ShowDialog() == DialogResult.OK)
            {
                ReloadItems();
            }
        }

        private void smazatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smazatPoložku oknoDelete = new smazatPoložku(items, (sett.Database) ? db : null);
            oknoDelete.ShowDialog();
            ReloadItems();
        }

        private void LoadFromFile()
        {
            listBoxNázev.Items.Clear();
            comboBox1.Items.Clear();
            poleObsah.Text = comboBox1.Text = String.Empty;
            items.Clear();
            if (sett.Database == false)
            {
                if (sett.přípona == ".csv")
                {
                    csvFile.Load(items);
                }
                else if (sett.přípona == ".xml")
                {
                    xmlFile.Load(items);
                }
            }
            else
            {
                db.Load(items);
            }
            comboBox1.Items.AddRange(items.GetCategories());
            upravitPoložkyToolStripMenuItem1.Enabled = smazatPoložkyToolStripMenuItem.Enabled = uložitToolStripMenuItem1.Enabled = ExportToolStripMenuItem.Enabled = !items.GetItemsList().Count.Equals(0);
            uložitToolStripMenuItem1.Visible = !sett.Database;
        }
        private void ReloadItems()
        {
            listBoxNázev.Items.Clear();
            comboBox1.Items.Clear();
            poleObsah.Text = comboBox1.Text = String.Empty;
            comboBox1.Items.AddRange(items.GetCategories());
            upravitPoložkyToolStripMenuItem1.Enabled = smazatPoložkyToolStripMenuItem.Enabled = uložitToolStripMenuItem1.Enabled = ExportToolStripMenuItem.Enabled = !items.GetItemsList().Count.Equals(0);
            uložitToolStripMenuItem1.Visible = !sett.Database;
        }

        private void uložitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sett.přípona == ".csv")
                    csvFile.Save(items);
                else if (sett.přípona == ".xml")
                    xmlFile.Save(items);
                MessageBox.Show("Data byla uložena", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.message + ex.Message + Environment.NewLine + "Zdroj" + ex.Source, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (exsett.Database)
                {
                    _50P.Software.Connect.MySql.ConnectMySQL connect = new _50P.Software.Connect.MySql.ConnectMySQL(exsett.server, exsett.username, SecurePass.GetUnprotectedPassword(exsett.password));
                    connect.setDatabase(exsett.dbname);
                    Export.Proceed(Export.filetype.MySQL, connect.Connection, items);
                }
                else
                    Export.Proceed((exsett.přípona == ".csv") ? Export.filetype.CSV : Export.filetype.XML, exsett.cestaKSouboru, items);
                MessageBox.Show("Export proběhl úspěšně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.message + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
