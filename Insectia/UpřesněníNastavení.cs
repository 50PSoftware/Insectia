using _50P.Software.Connect.MySql;
using _50P.Software.IPLocal;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace Insectia
{
    partial class UpřesněníNastavení : Form
    {
        ExportSettings exsett = new ExportSettings();
        ConnectMySQL conmysql;
        getIP ip50p;
        Settings sett = new Settings();
        public UpřesněníNastavení()
        {
            InitializeComponent();
        }

        private void UpřesněníNastavení_Load(object sender, EventArgs e)
        {
            sett.Reload();
            Text = "Upřesnění nastavení";
            if (exsett.remember)
            {
                checkBoxRememberExportSettings.Checked = checkBoxRememberExportSettings.Enabled = true;
                checkBoxVytvořitPřiZavření.Visible = true;
                if (exsett.Database)
                {
                    radioButtonDatabáze.Checked = true;
                    buttonProcházet1.Enabled = false;
                    groupBoxDatabáze.Visible = true;
                    poleNázevDatabáze.Text = exsett.dbname;
                    poleServer.Text = exsett.server;
                    poleFilename.Text = poleNázevDatabáze.Text + "@" + poleServer.Text;
                    poleFilename.ReadOnly = true;
                    poleUsername.Text = exsett.username;
                    polePassword.Text = SecurePass.GetUnprotectedPassword(exsett.password);
                }
                else
                {
                    radioButtonSoubor.Checked = true;
                    poleFilename.Text = exsett.cestaKSouboru;
                    poleFilename.ReadOnly = false;
                    buttonProcházet1.Enabled = true;
                    groupBoxDatabáze.Visible = false;
                }
            }
            else
            {
                checkBoxRememberExportSettings.Checked = checkBoxRememberExportSettings.Enabled = false;
                buttonProcházet1.Enabled = false;
                poleFilename.Enabled = false;
                groupBoxDatabáze.Visible = false;
                poleUsername.Text = exsett.username;
                checkBoxVytvořitPřiZavření.Visible = false;
            }
            poleUsername1.Text = sett.username;
            polePassword1.Text = SecurePass.GetUnprotectedPassword(sett.password);
            poleNázevDatabáze1.Text = sett.dbname;
            poleServer1.Text = sett.server;
            groupBoxDatabaseInfo.Enabled = (sett.useDatabase) ? true : false;
            checkBoxPoužívatDatabázi.Checked = (sett.useDatabase) ? true : false;
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDatabáze.Checked)
            {
                buttonProcházet1.Enabled = false;
                exsett.Database = true;
                groupBoxDatabáze.Visible = true;
                poleServer.Enabled = (poleNázevDatabáze.Text != "") ? true : false;
                poleFilename.Text = (poleNázevDatabáze.Text != "" && poleServer.Text != "") ? poleNázevDatabáze.Text + "@" + poleServer.Text : null;
                polePassword.Enabled = (poleUsername.Text != "") ? true : false;
                checkBoxVytvořitPřiZavření.Visible = false;
                poleFilename.ReadOnly = true;
            }
            else
            {
                buttonProcházet1.Enabled = true;
                exsett.Database = false;
                groupBoxDatabáze.Visible = false;
                poleFilename.Text = null;
                poleFilename.ReadOnly = false;
                checkBoxVytvořitPřiZavření.Text = "Vytvořit soubor při zavření";
                checkBoxVytvořitPřiZavření.Visible = true;
            }
            poleFilename.Enabled = true;
            checkBoxRememberExportSettings.Enabled = poleFilename.Text.Length < 0;
            checkBoxVytvořitPřiZavření.Enabled = false;
        }

        private void checkBoxRememberExportSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRememberExportSettings.Checked)
            {
                exsett.remember = true;
                checkBoxVytvořitPřiZavření.Checked = true;
            }
            else
            {
                exsett.remember = false;
                exsett.Reset();
                exsett.Save();
                checkBoxVytvořitPřiZavření.Checked = false;
            }
        }

        private void buttonProcházet1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Uložit do souboru";
            save.Filter = "CSV soubory (*.csv)|*.csv";
            if (save.ShowDialog() == DialogResult.OK)
            {
                poleFilename.Text = save.FileName;
                exsett.přípona = Path.GetExtension(poleFilename.Text);
            }
        }

        private void UpřesněníNastavení_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxRememberExportSettings.Checked)
            {
                if (radioButtonDatabáze.Checked)
                {
                    exsett.Database = true;
                    if (poleFilename.Text != "")
                    {
                        string[] hodnoty = poleFilename.Text.Split('@');
                        exsett.dbname = hodnoty[0];
                        exsett.server = hodnoty[1];
                    }
                    exsett.username = (poleUsername.Text != "") ? poleUsername.Text : null;
                    exsett.password = (polePassword.Text != "") ? SecurePass.GetProtectedPassword(polePassword.Text) : null;
                }
                else
                {
                    exsett.cestaKSouboru = (poleFilename.Text != "") ? poleFilename.Text : null;
                }
                exsett.Save();
            }
            if (checkBoxVytvořitPřiZavření.Checked)
            {
                if (radioButtonDatabáze.Checked)
                {
                    long pocetPolozek = 0;
                    MySqlConnection připojení = new MySqlConnection();
                    conmysql = new ConnectMySQL(poleServer.Text, poleUsername.Text, polePassword.Text);
                    conmysql.setDatabase(poleNázevDatabáze.Text);
                    MySqlCommand command = new MySqlCommand("select count(*) from item union select count(*) from category;");
                    připojení.ConnectionString = conmysql.Connection;
                    command.Connection = připojení;
                    try
                    {
                        připojení.Open();
                        pocetPolozek = (long)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Program.message + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        připojení.Close();
                    }
                    if (pocetPolozek > 0)
                    {
                        toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                        toolTip1.ToolTipTitle = "Pozor";
                        toolTip1.IsBalloon = true;
                        toolTip1.ShowAlways = true;
                        toolTip1.SetToolTip(poleFilename, "Databáze není prázdná!");
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                }
                else
                {
                    CSV csvfile = new CSV(poleFilename.Text);
                    try
                    {
                        csvfile.New();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Program.message + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            sett.username = (poleNázevDatabáze1.Text != "") ? poleUsername1.Text : null;
            sett.password = (polePassword1.Text != "") ? SecurePass.GetProtectedPassword(polePassword1.Text) : null;
            sett.dbname = (poleNázevDatabáze1.Text != "") ? poleNázevDatabáze1.Text : null;
            sett.server = (poleServer1.Text != "") ? poleServer1.Text : null;
            sett.useDatabase = (checkBoxPoužívatDatabázi.Checked) ? true : false;
            sett.Save();
        }

        private void poleNDaS_TextChanged(object sender, EventArgs e)
        {
            poleServer.Enabled = poleNázevDatabáze.Text != "";
            poleFilename.Text = (poleNázevDatabáze.Text != "") ? poleNázevDatabáze.Text + "@" + poleServer.Text : null;
        }

        private void poleNDaS_Enter(object sender, EventArgs e)
        {
            poleServer.Enabled = poleNázevDatabáze.Text != "";
            poleFilename.Text = (poleNázevDatabáze.Text != "") ? poleNázevDatabáze.Text + "@" + poleServer.Text : null;
        }

        private void poleUsername_TextChanged(object sender, EventArgs e)
        {
            polePassword.Enabled = poleUsername.Text != "";
        }

        private void poleUsername_Enter(object sender, EventArgs e)
        {
            polePassword.Enabled = poleUsername.Text != "";
        }

        private void poleFilename_TextChanged(object sender, EventArgs e)
        {
            checkBoxVytvořitPřiZavření.Enabled = checkBoxRememberExportSettings.Checked = checkBoxRememberExportSettings.Enabled = (poleFilename.Text != "") ? true : false;
            if ((poleFilename.Text == sett.cestaKSouboru || poleFilename.Text == sett.dbname + "@" + sett.server) && poleFilename.Text.Length > 0)
            {
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.ToolTipTitle = "Pozor";
                toolTip1.IsBalloon = true;
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(poleFilename, "Cesta k souboru se musí lišit!!");
                checkBoxRememberExportSettings.Checked = false;
                checkBoxRememberExportSettings.Enabled = false;
            }
            else
            {
                checkBoxRememberExportSettings.Enabled = true;
            }
        }

        private void poleFilename_Enter(object sender, EventArgs e)
        {
            checkBoxVytvořitPřiZavření.Enabled = checkBoxRememberExportSettings.Checked = checkBoxRememberExportSettings.Enabled = (poleFilename.Text != "") ? true : false;
            if ((poleFilename.Text == sett.cestaKSouboru || poleFilename.Text == sett.dbname + "@" + sett.server) && poleFilename.Text.Length > 0)
            {
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.ToolTipTitle = "Pozor";
                toolTip1.IsBalloon = true;
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(poleFilename, "Cesta k souboru se musí lišit!!");
                checkBoxRememberExportSettings.Checked = false;
                checkBoxRememberExportSettings.Enabled = false;
            }
            else
            {
                checkBoxRememberExportSettings.Enabled = true;
            }
        }

        private void checkBoxPoužívatDatabázi_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDatabaseInfo.Enabled = (checkBoxPoužívatDatabázi.Checked) ? true : false;
            if (!checkBoxPoužívatDatabázi.Checked)
            {
                poleNázevDatabáze1.Text = poleServer1.Text = poleUsername1.Text = polePassword1.Text = null;
            }
        }

        private void poleNázevDatabáze1_TextChanged(object sender, EventArgs e)
        {
            poleServer1.Enabled = poleNázevDatabáze1.Text != "";
        }

        private void groupBoxDatabaseInfo_Enter(object sender, EventArgs e)
        {
            poleServer1.Enabled = (poleNázevDatabáze1.Text != "") ? true : false;
            polePassword1.Enabled = (poleUsername1.Text != "") ? true : false;
        }

        private void poleUsername1_TextChanged(object sender, EventArgs e)
        {
            polePassword1.Enabled = poleUsername1.Text != "";
        }
    }
}
