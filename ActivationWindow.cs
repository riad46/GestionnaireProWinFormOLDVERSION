using Gestionnaire_Pro.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class ActivationWindow : Form
    {
        public ActivationWindow()
        {
            InitializeComponent();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            var realCode = ProgramActivation.GetThisActivationCode();
            if (code_txt.Text == realCode)
            {
                Properties.Settings.Default.isActivated = true;
                Properties.Settings.Default.activationCode = realCode;
                Properties.Settings.Default.Save();
                using (var m= new Menu())
                {
                    m.ShowDialog();
                    Close();
                }
            }
            else
            {
                code_txt.Text = "";
                MessageBox.Show("Code Incorrect!!!");
            }
        }
    }
}
