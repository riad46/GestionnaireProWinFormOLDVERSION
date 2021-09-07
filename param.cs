using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class param : Form
    {
        public param()
        {
            InitializeComponent();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.activeLogin = loginAcrive_checkBox.Checked;
            Properties.Settings.Default.autoCodeBarre = autoCodeBarre_checkBox.Checked;
            Properties.Settings.Default.Save();


        }

        private void param_Load(object sender, EventArgs e)
        {
            loginAcrive_checkBox.Checked = Properties.Settings.Default.activeLogin;
            autoCodeBarre_checkBox.Checked = Properties.Settings.Default.autoCodeBarre;
        }
    }
}
