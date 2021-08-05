using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
   
    public partial class infosBoutique : Form
    {
        private string _imageLocation = "";
        private Bitmap _myImage = null;
        public infosBoutique()
        {
            InitializeComponent();
        }
        private void PutImageInPictureBox()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = _myImage;
        }
        private void FilltheBoxes(InfoBoutique myInfos)
        {
            nom_txt.Text = myInfos.nomBoutique;
            address_txt.Text = myInfos.address;
            numTlf_txt.Text = myInfos.numTlf;
            if (myInfos.logo != null) {
                _myImage = GlobalClass.byteArrayToImage(myInfos.logo);
                PutImageInPictureBox();
            }
            
        }
        
        private void ActionToDo()
        {
            var myInfos = new InfoBoutique
            {
                nomBoutique = nom_txt.Text,
                numTlf = numTlf_txt.Text,
                address = address_txt.Text

            };
            if (_imageLocation != "")
                myInfos.logo = GlobalClass.ImageToBinary(_imageLocation);

            switch (GlobalClass.typeOp)
            {

                case 0:

                    GestionnaireProInsertingMethods.AddInfoBoutique(myInfos);
                    MessageBox.Show("Les informations du Boutique ont été ajouté avec succée");

                    break;
                case 1:
                    GestionnaireProModifyDeleteMethods.ModifyInfosBoutique(myInfos);
                    MessageBox.Show("Les informations du Boutique ont été modifier avec succée");

                    break;
                default:
                    break;
            }
        }


        private void img_btn_Click(object sender, EventArgs e)
        {
            using (var imgChoosingForm = new OpenFileDialog())
            {
                //set the dialogue properties
                imgChoosingForm.Title = "Séléctionné le Logo";
                imgChoosingForm.Filter = @" Image Type (*.jpg ; *.jpeg ; *.png ; *.gif ; *.tiff ; *.nef)
                                | *.jpg; *.jpeg; *.png; *.gif; *.tiff; *.nef";

                imgChoosingForm.ShowDialog();
                _imageLocation = imgChoosingForm.FileName;


                //create Instance of Image
                _myImage = (Bitmap)Bitmap.FromFile(_imageLocation);

                //set  pictureBox property to resize the Image 
                PutImageInPictureBox();
                


            }
        }
      
     
        private void sub_btn_Click(object sender, EventArgs e)
        {

            ActionToDo();
        }

        private void infosBoutique_Load(object sender, EventArgs e)
        {
            var numRows=GestionnaireProRetreivingMethods.RetreiveNumRows("infosBoutique").Result;
            if (numRows > 0)
            {
                GlobalClass.typeOp = 1;
                var myInfos=GestionnaireProRetreivingMethods.GetBoutiqueInfos().Result;
               
                FilltheBoxes(myInfos);            }
            else
            {
                GlobalClass.typeOp = 0;
            }
        }

        private void infosBoutique_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_myImage!=null)
            _myImage.Dispose();
        }

        private void deleteImg_btn_Click(object sender, EventArgs e)
        {
            _myImage = null;
            PutImageInPictureBox();
        }
    }
}
