using Gestionnaire_Pro.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
   
        static void Main() 
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //check for activation code 
           
                

            if (Properties.Settings.Default.isActivated == true && ProgramActivation.GetThisActivationCode() == Properties.Settings.Default.activationCode)
            {
                Application.Run(new Menu());
            }
            else
            { 
         
                Properties.Settings.Default.isActivated = false;
                Properties.Settings.Default.activationCode = "";
                Properties.Settings.Default.Save();
                Application.Run(new ActivationWindow());
            }



        }
    }
}
