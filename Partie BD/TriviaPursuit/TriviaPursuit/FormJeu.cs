using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


// gainsboro / indigo

namespace TriviaPursuit
{

   public partial class FormJeu : Form
   {
      public Image conteneur;
      public int compteur = 0;
      public Random NombreAleatoire = new Random();
      public int NombreDeRotation;
      public string Categorie = "";

      // variable contenant la connection a la bd 
      OracleConnection oraconn = new OracleConnection();
      string Joueur1;
      string Joueur2;
      string Joueur3;
      string Joueur4;
      string TourDe;

      public FormJeu(OracleConnection oraconnPrincipale, string J1 = "", string J2 = "", string J3 = "", string J4 = "")
      {
         Joueur1 = J1;
         Joueur2 = J2;
         Joueur3 = J3;
         Joueur4 = J4;
         InitializeComponent();
         oraconn = oraconnPrincipale; 
      }

      private void BTN_Surrender_Click(object sender, EventArgs e)
      {
         var resultat = MessageBox.Show("Êtes vous sur de vouloir quitter ? Vous allez perdre tout statistiques de jeu. ", "Attention !", MessageBoxButtons.YesNo);

         if (resultat == DialogResult.Yes)
            this.Close();
      }

      private void FormJeu_Load(object sender, EventArgs e)
      {
         LoadGroupBox();
         conteneur = pictureBox1.Image;
         TourDe = Joueur1;
      }
      private void UpdateControls()
      {         
         if(TourDe ==Joueur1)
         {
            GB_J1.ForeColor = Color.Yellow;
            GB_J1.Font = new Font (GB_J1.Font, FontStyle.Bold);
         }
         else if(TourDe == Joueur2)
         {
            GB_J2.ForeColor = Color.Yellow;
            GB_J2.Font = new Font(GB_J2.Font, FontStyle.Bold);
         }
         else if(TourDe == Joueur3)
         {
            GB_J3.ForeColor = Color.Yellow;
            GB_J3.Font = new Font(GB_J3.Font, FontStyle.Bold);
         }
         if(TourDe == Joueur4)
         {
            GB_J4.ForeColor = Color.Yellow;
            GB_J4.Font = new Font(GB_J4.Font, FontStyle.Bold);
         }

      }

      private void ProchainJoueur()
      {
         

      }

      private void LoadGroupBox()
      {
         GB_J1.Text = Joueur1;
         GB_J2.Text = Joueur2;

         if (Joueur3 != "")
         {
            GB_J3.Text = Joueur3;
         }
         else
         {
            GB_J3.Visible = false;
            GB_J3.Enabled = false;
         }
         if (Joueur4 != "")
         {
            GB_J4.Text = Joueur4;
         }
         else
         {
            GB_J4.Visible = false;
            GB_J4.Enabled = false;
         }
      }

      private void BTN_Rules_Click(object sender, EventArgs e)
      {
         FormReglements form = new FormReglements();

         form.Show();
      }

      //////////////////////////////////////////////////////////////////////////////////////////////
      //    Gestion des erreurs 
      //////////////////////////////////////////////////////////////////////////////////////////////
      private void GestionErreur(OracleException ex)
      {
         FormErreur form = new FormErreur(ex);

         if (form.ShowDialog() == DialogResult.Abort)
         {
            this.DialogResult = DialogResult.Abort;
         }
      }
      private static Bitmap RotateImageByAngle(System.Drawing.Image oldBitmap, float angle)
      {
         var newBitmap = new Bitmap(oldBitmap.Width, oldBitmap.Height);
         var graphics = Graphics.FromImage(newBitmap);
         graphics.TranslateTransform((float)oldBitmap.Width / 2, (float)oldBitmap.Height / 2);
         graphics.RotateTransform(angle);
         graphics.TranslateTransform(-(float)oldBitmap.Width / 2, -(float)oldBitmap.Height / 2);
         graphics.DrawImage(oldBitmap, new Point(0, 0));
         return newBitmap;
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {

         timer1.Interval = 25;
         timer1.Enabled = true;
         do
         {
            NombreDeRotation = NombreAleatoire.Next(73, 108);
         }while(NombreDeRotation == 0 && NombreDeRotation == 79 && NombreDeRotation == 86 && NombreDeRotation == 94 && NombreDeRotation == 101 && NombreDeRotation == 108);

         NombreDeRotation = 88;
      }
      private void PopCategorie()
      {   
        
         if(NombreDeRotation >= 73 && NombreDeRotation <= 79)
         {
            Categorie = "Animaux";
         }
         else if(NombreDeRotation >= 79 && NombreDeRotation <= 86)
         {
            Categorie = "Musique";
         }
         else if(NombreDeRotation >= 86 && NombreDeRotation <= 94)
         {
            Choix.Visible = true;           
         }
         else if(NombreDeRotation >= 94 && NombreDeRotation <= 101)
         {
            Categorie = "Jeu vidéo";
         }
         else if(NombreDeRotation >= 101 && NombreDeRotation <= 108)
         {
            Categorie = "Culinaire";
         }
         if(Categorie=="")
         { 
            FormQuestion question = new FormQuestion(oraconn, "Jeu vidéo", "Charlie");
            question.Show();
         }
        
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         if (compteur <= NombreDeRotation)
         {
            pictureBox1.Image = RotateImageByAngle(conteneur, 10 * compteur);
            pictureBox1.Refresh();
            compteur++;
         }
         else
         {
            compteur = 0;
            timer1.Enabled = false;
            PopCategorie();
            
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         Categorie =Choix.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
         Choix.Visible = false;
        
      }
   }
}
