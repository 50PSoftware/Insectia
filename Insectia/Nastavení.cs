using _50P.Software.Connect.MySql;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace Insectia
{
    partial class Nastavení : Form
    {
        ConnectMySQL conmysql;
        Settings settings = new Settings();
        _50P.Software.IPLocal.getIP ip50p;

        FirstRunSetting FRS = new FirstRunSetting();
        CSV csvFile;
        XML xmlFile;
        public Nastavení()
        {
            InitializeComponent();
            this.ShowInTaskbar = FRS.FirstRun ? true : false;
            this.StartPosition = FRS.FirstRun ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void Nastavení_Load(object sender, EventArgs e)
        {
            try
            {
                if (settings.Database)
                {
                    radioButtonDatabáze.Checked = true;
                }
                else
                    radioButtonSoubor.Checked = true;
                if (FRS.FirstRun == false)
                {
                    bool exists = File.Exists(settings.cestaKSouboru);
                    if (exists)
                        poleFilename.Text = settings.cestaKSouboru;
                    if (settings.Database)
                    {
                        poleFilename.Text = $"{settings.dbname}@{settings.server}";
                        try
                        {
                            ip50p = new _50P.Software.IPLocal.getIP(true, settings.server);
                            conmysql = new ConnectMySQL(ip50p.IP, settings.username, SecurePass.GetUnprotectedPassword(settings.password));
                            MySqlConnection připojení = new MySqlConnection();
                            conmysql.setDatabase(settings.dbname);
                            připojení.ConnectionString = conmysql.Connection;
                            připojení.Open();
                            připojení.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Program.message + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (exists == false && settings.cestaKSouboru != null)
                    {
                        DialogResult odpověď = MessageBox.Show("Požadovaný soubor neexistuje! Byl zřejmě smazán!" + Environment.NewLine + "Přejete si jej vytvořit?", "Chyba", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (odpověď == DialogResult.Yes)
                        {
                            if (settings.přípona == ".csv")
                            {
                                csvFile = new CSV(settings.cestaKSouboru);
                                csvFile.New();
                                poleFilename.Text = settings.cestaKSouboru;
                            }
                            else if (settings.přípona == ".xml")
                            {
                                xmlFile = new XML(settings.cestaKSouboru);
                                xmlFile.New();
                                poleFilename.Text = settings.cestaKSouboru;
                            }
                        }
                    }
                }
                else
                {
                    DialogResult ans = MessageBox.Show("Budete používat databázi?", "Vítejte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        settings.useDatabase = true;
                        settings.Save();
                        MessageBox.Show("Ze všeho nejdříve nastavte přístup k databázi.", "Než začnete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        UpřesněníNastavení oknoUN = new UpřesněníNastavení();
                        oknoUN.ShowDialog();
                        settings.Reload();
                    }
                    else if (ans == DialogResult.No)
                    {
                        MessageBox.Show("Před připojením k databázi nastavte příslušné hodnoty (v upřesnění nastavení)...", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (ans == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    buttonDefault.Enabled = false;
                }
            }
            finally
            {
                buttonOK.DialogResult = DialogResult.OK;
                bool nonull = poleFilename.Text != "";
                buttonOK.Enabled = nonull;
                buttonDefault.DialogResult = DialogResult.Retry;
                radioButtonDatabáze.Enabled = (settings.useDatabase) ? true : false;
                buttonBrowse.Enabled = false;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonDatabáze.Checked)
            {
                settings.Database = true;
                ip50p = new _50P.Software.IPLocal.getIP();
                try
                {
                    string[] hodnoty = poleFilename.Text.Split('@');
                    try
                    {
                        settings.server = hodnoty[1];
                        settings.dbname = hodnoty[0];
                        settings.Save();
                    }
                    catch
                    {
                        MessageBox.Show("Nepodařilo se uložit nastavení!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ip50p.HOST(hodnoty[1]);
                    MySqlConnection připojení = new MySqlConnection();
                    conmysql = new ConnectMySQL(ip50p.IP, settings.username, SecurePass.GetUnprotectedPassword(settings.password));
                    conmysql.setDatabase(hodnoty[0]);
                    připojení.ConnectionString = conmysql.Connection;
                    připojení.Open();
                    připojení.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Program.message + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult ans = MessageBox.Show("Přejete si nastavení resetovat? (doporučeno)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        settings.Reset();
                    }
                }
            }
            else if (radioButtonSoubor.Checked)
                settings.Database = false;
            settings.Save();
            FRS.FirstRun = false;
            if (checkBoxVytvořit1.Checked)
            {
                if (settings.přípona == ".csv")
                {
                    csvFile = new CSV(settings.cestaKSouboru);
                    csvFile.New();
                    poleFilename.Text = settings.cestaKSouboru;
                }
                else if (settings.přípona == ".xml")
                {
                    xmlFile = new XML(settings.cestaKSouboru);
                    xmlFile.New();
                    poleFilename.Text = settings.cestaKSouboru;
                }
            }
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            ExportSettings exsett = new ExportSettings();
            exsett.Reset();
            exsett.Save();
            settings.Reset();
            settings.Save();
            this.Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (checkBoxVytvořit1.Checked)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Uložit soubor";
                save.Filter = (comboBoxFileType1.Text == "CSV soubor") ? "Tabulkové soubory (*.csv)|*.csv" : "XML soubory (*.xml)|*.xml";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    poleFilename.Text = save.FileName;
                    settings.cestaKSouboru = save.FileName;
                    settings.přípona = Path.GetExtension(poleFilename.Text);
                    settings.Save();
                }
            }
            else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "Otevřít soubor";
                open.Filter = (comboBoxFileType1.Text == "CSV soubor") ? "Tabulkové soubory (*.csv)|*.csv" : "XML soubory (*.xml)|*.xml";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    poleFilename.Text = open.FileName;
                    settings.cestaKSouboru = open.FileName;
                    settings.přípona = Path.GetExtension(poleFilename.Text);
                    settings.Save();
                }
            }
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFileType1.Items.Clear();
            if (radioButtonSoubor.Checked)
            {
                comboBoxFileType1.Items.Add("CSV soubor");
                comboBoxFileType1.Items.Add("XML soubor");
                checkBoxVytvořit1.Enabled = buttonBrowse.Enabled = true;
            }
            else
            {
                comboBoxFileType1.Items.Add("MySQL");
                checkBoxVytvořit1.Enabled = checkBoxVytvořit1.Checked = buttonBrowse.Enabled = false;
            }
        }

        private void poleFilename_TextChanged(object sender, EventArgs e)
        {
            bool nonull = poleFilename.Text != "";
            buttonOK.Enabled = nonull;
        }

        private void buttonUpřesnit_Click(object sender, EventArgs e)
        {
            settings.Save();
            UpřesněníNastavení oknoUN = new UpřesněníNastavení();
            oknoUN.ShowDialog();
            settings.Reload();
            radioButtonDatabáze.Enabled = (settings.useDatabase) ? true : false;
            if (radioButtonDatabáze.Enabled == false)
            {
                radioButtonSoubor.Checked = true;
            }
        }

        private void Nastavení_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FRS.FirstRun)
            {
                DialogResult ans = MessageBox.Show("Aplikace běží poprvé. Při dalším spuštění nebo dalším pokusu o nastavení budete znovu dotázáni, zda budete používat databázi či nikoli.\nSouhlasíte s tím?", "Otázka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    FRS.FirstRun = true;
                }
                else
                {
                    FRS.FirstRun = false;
                }
                this.DialogResult = DialogResult.Abort;
                FRS.Save();
            }
            else if (this.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                FRS.Save();
            }
            else if(this.DialogResult == DialogResult.Retry)
            {
                this.DialogResult = DialogResult.Retry;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void comboBoxFileType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFileType1.SelectedIndex < 0)
            {
                buttonBrowse.Enabled = false;
            }
            else
            {
                if (!settings.useDatabase)
                    buttonBrowse.Enabled = true;
                else if (radioButtonDatabáze.Checked)
                {
                    poleFilename.Text = settings.dbname + "@" + settings.server;
                }
            }
        }
    }
}
