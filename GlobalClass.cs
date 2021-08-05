using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Gestionnaire_Pro
{
    public class GlobalClass
    {
        /// <summary>
        /// type 0 = add to Database,
        /// type 1 = Modify the Database row,
        /// type 3 = delete record,
        /// type 4 =delete all records from DB
        /// </summary>
        public static short typeOp = 0;
       /// <summary>
       /// To use after Login (Give the roles) 
       /// </summary>
        public static string username="" ;
        public static bool isAdmin=true;

        public static void AddAction(string descriptionAction)
        {

            GestionnaireProInsertingMethods.AddActionEffectué(new ActionEffectuer
            {
                descriptionAction = descriptionAction,

                nomUtilisateur = username,
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
    }
}
