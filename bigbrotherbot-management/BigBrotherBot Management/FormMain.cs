/*  Copyright (C) 2014  Vincent Cunningham

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA. */

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BigBrotherBot_Management
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string Executable { get; set; }

        public string Config { get; set; }

        private void btnBrowseExecutable_Click(object sender, EventArgs e)
        {
            if (ofdExecutable.ShowDialog() != DialogResult.OK) return;

            Executable = ofdExecutable.FileName;
            lblExecutable.Text = Executable;
            btnRun.Enabled = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string arguments = String.Empty;

            if (!String.IsNullOrEmpty(Config))
            {
                arguments += " -c " + Config;
            }

            if (chkRestart.Checked)
            {
                arguments += " -r";
            }

            if (Path.GetExtension(lblExecutable.Text) == ".py")
            {
                try
                {
                    Process.Start("python", Executable + arguments);
                }
                catch (Exception)
                {
                    MessageBox.Show(Properties.Resources.PythonNotFound, Properties.Resources.Error);
                }
            }
            else
            {
                Process.Start(lblExecutable.Text, arguments);
            }
        }

        private void btnBrowseConfig_Click(object sender, EventArgs e)
        {
            if (ofdConfig.ShowDialog() != DialogResult.OK) return;

            Config = ofdConfig.FileName;

            ConfigHelper.LoadConfig(this);

            lblConfig.Text = Properties.Resources.ConfigFile + ofdConfig.SafeFileName;
            btnSaveConfig.Enabled = true;
            tabConfiguration.Enabled = true;
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (sfdConfig.ShowDialog() != DialogResult.OK) return;

            XDocument config = ConfigHelper.SaveConfig(this);

            config.Save(sfdConfig.FileName);
        }

        private void btnLogFile_Click(object sender, EventArgs e)
        {
            if (fbdLogFile.ShowDialog() != DialogResult.OK) return;

            txtLogFile.Text = fbdLogFile.SelectedPath + @"\b3.log";
        }

        private void btnBrowseGameLog_Click(object sender, EventArgs e)
        {
            if (ofdGameLog.ShowDialog() != DialogResult.OK) return;

            txtGameLog.Text = ofdGameLog.FileName;
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            if (fbdAutodoc.ShowDialog() != DialogResult.OK) return;

            if (cmbType.SelectedItem.ToString().Equals("xml"))
                txtLogFile.Text = fbdAutodoc.SelectedPath + @"\b3_doc.xml";
            else
                txtLogFile.Text = fbdLogFile.SelectedPath + @"\b3_doc.html";
        }
    }
}