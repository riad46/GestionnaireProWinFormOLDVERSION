using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class historiqueAction : Form
    {
        private List<ActionEffectuer> _mesAction = new List<ActionEffectuer>();
        public historiqueAction()
        {
            InitializeComponent();
        }
        private void SetUpTable()
        {
            actionsTable.AutoGenerateColumns = false;
            actionsTable.DataSource = _mesAction;

        }
        private void historiqueAction_Load(object sender, EventArgs e)
        {

            _mesAction = GestionnaireProRetreivingMethods.GetAllActions().Result;
            _mesAction.Reverse();
            SetUpTable();
        }
    }
}
