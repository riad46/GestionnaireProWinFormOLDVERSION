using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public class GlobalClass
    {
        /// <summary>
        /// type 0 = add to Database,
        /// type 1 = Modify the Database row,
        /// type 3 = delete record,
        /// type 4 =delete all records from DB
        /// 10 = add an article  to List from Article List 
        /// </summary>
        public static short typeOp = 0;
       /// <summary>
       /// To use after Login (Give the roles) 
       /// </summary>
        public static string username="" ;
        public static bool isAdmin=true;
        internal static bool isSuperAdmin=false;

        public static void AddAction(string username,string descriptionAction)
        {

            GestionnaireProInsertingMethods.AddActionEffectué(new ActionEffectuer
            {
                descriptionAction = descriptionAction,

                utilisateur = username,
                dateAction = DateTime.Now
            }) ;


        }
        public static System.Drawing.Bitmap byteArrayToImage(byte[] myImageByteArray)
        {
            if (myImageByteArray == null) return null;
            return (System.Drawing.Bitmap)((new System.Drawing.ImageConverter()).ConvertFrom(myImageByteArray));
        }
        public static byte[] ImageToBinary(string imageLocation)
        {
            byte[] data = null;
            var myImageLength = new System.IO.FileInfo(imageLocation).Length;
            if (System.IO.File.Exists(imageLocation))
            {

                //Retreave image from file and binary it to Object image
                data = (byte[])(new System.Drawing.ImageConverter()).ConvertTo(System.Drawing.Image.FromFile(imageLocation), typeof(byte[]));

            }
            return data;
        }
    
         public static void CheckForInputToBeNumbers(KeyPressEventArgs e,TextBox t1 )
        {
            char ch = e.KeyChar;
            
            if(ch=='-' && t1.Text.IndexOf('-') != -1)
            {
                e.Handled = true;
                return;
            }
                if ((ch == 44 || ch == 46 ) && (t1.Text.IndexOf(',') != -1 || t1.Text.IndexOf('.') != -1))
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 44 && ch != 8 && ch!='-')
            {
                e.Handled = true;
            }
            if (ch == '.')
            {

                t1.AppendText(",");
                return;

            }
        }

        public static void CheckForArticleQnt(float minQNT)
        {
            var listArticles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
            var articlesExcluDeVérificationIds = GestionnaireProRetreivingMethods.GetQntNONVerifiedProducts().Result;
            foreach (var articleExclu in articlesExcluDeVérificationIds)
            {
                var index = listArticles.FindIndex(a => a.Id == articleExclu.Id);
                if(index>-1)
                listArticles.RemoveAt(index);
            }
            foreach (var article in listArticles)
            {
                if (article.quantité <= minQNT)
                {
                    MessageBox.Show(new Form(),@$"Vérifier Votre Stock !Au Minimum:
l'Article : {article.nom} A Seulement Quantité = {article.quantité} Restant !!!!!!","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                   
                }
                
            }

        }
        public static void CheckForArticlesExpirationDate(float numberOfDays)
        {
            var listArticles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
            var articlesExcluDeVérificationIds = GestionnaireProRetreivingMethods.GetDateNONVerifiedProducts().Result;
            foreach (var articleExclu in articlesExcluDeVérificationIds)
            {
                var index = listArticles.FindIndex(a => a.Id == articleExclu.Id);
                if(index>-1)
                listArticles.RemoveAt(index);
            }
           
            foreach (var article in listArticles)
            {
                if(article.dateExpiration != null)
                {
                    var numDays = (DateTime.Now - article.dateExpiration).Value.Days;
                    if ( numDays <= numberOfDays)
                    {
                        
                        
                        MessageBox.Show(new Form(),@$"Vérifier Votre Stock !Au Minimum :
l'Article : {article.nom} A Seulement  {numDays} Jours Restant jusqu'à Expiration !!!!!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                   
                   
            }
        }
       
    }
}
