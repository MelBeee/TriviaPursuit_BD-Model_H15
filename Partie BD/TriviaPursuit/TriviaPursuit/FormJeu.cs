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
using System.Media;


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
      System.Media.SoundPlayer player = new System.Media.SoundPlayer();

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
         PN_Win.Visible = false;
         LoadGroupBox();
         conteneur = PB_Roulette.Image;
         TourDe = Joueur1;
         UpdateControls();
      }
      private void UpdateControls()
      {
         LB_TourAUser.Text = "C'est au tour de " + TourDe + " !";

         GB_J1.ForeColor = Color.White;
         GB_J1.Font = new Font(GB_J1.Font, FontStyle.Regular);
         GB_J2.ForeColor = Color.White;
         GB_J2.Font = new Font(GB_J2.Font, FontStyle.Regular);
         GB_J3.ForeColor = Color.White;
         GB_J3.Font = new Font(GB_J3.Font, FontStyle.Regular);
         GB_J4.ForeColor = Color.White;
         GB_J4.Font = new Font(GB_J4.Font, FontStyle.Regular);

         if (TourDe == Joueur1)
         {
            GB_J1.ForeColor = Color.Yellow;
            GB_J1.Font = new Font(GB_J1.Font, FontStyle.Bold);
         }
         else if (TourDe == Joueur2)
         {
            GB_J2.ForeColor = Color.Yellow;
            GB_J2.Font = new Font(GB_J2.Font, FontStyle.Bold);
         }
         else if (TourDe == Joueur3)
         {
            GB_J3.ForeColor = Color.Yellow;
            GB_J3.Font = new Font(GB_J3.Font, FontStyle.Bold);
         }
         if (TourDe == Joueur4)
         {
            GB_J4.ForeColor = Color.Yellow;
            GB_J4.Font = new Font(GB_J4.Font, FontStyle.Bold);
         }
      }

      private void ProchainJoueur()
      {
         if (TourDe == Joueur1)
         {
            TourDe = Joueur2;
         }
         else if (TourDe == Joueur2 && Joueur3 != "")
         {
            TourDe = Joueur3;
         }
         else if (TourDe == Joueur3 && Joueur4 != "")
         {
            TourDe = Joueur4;
         }
         else if (TourDe == Joueur4 || TourDe == Joueur3 || TourDe == Joueur2)
         {
            TourDe = Joueur1;
         }
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

      private void PB_Roulette_Click(object sender, EventArgs e)
      {
         timer1.Interval = 25;
         timer1.Enabled = true;
         do
         {
            NombreDeRotation = NombreAleatoire.Next(73, 108);
         } while (NombreDeRotation == 0 &&
                  NombreDeRotation == 79 &&
                  NombreDeRotation == 86 &&
                  NombreDeRotation == 94 &&
                  NombreDeRotation == 101 &&
                  NombreDeRotation == 108);

         JouerSonRoulette();
      }

      private void JouerSonRoulette()
      {
         player.Stream = Properties.Resources.WheelSpin;
         player.Play();
      }

      private void PopCategorie()
      {
         System.Threading.Thread.Sleep(1000);
         if (NombreDeRotation >= 73 && NombreDeRotation <= 79)
         {
            Categorie = "Animaux";
            PopQuestion(Categorie);
         }
         else if (NombreDeRotation >= 79 && NombreDeRotation <= 86)
         {
            Categorie = "Musique";
            PopQuestion(Categorie);
         }
         else if (NombreDeRotation >= 86 && NombreDeRotation <= 94)
         {
            Choix.Visible = true;
            UpdateButton();
         }
         else if (NombreDeRotation >= 94 && NombreDeRotation <= 101)
         {
            Categorie = "Jeu vidéo";
            PopQuestion(Categorie);
         }
         else if (NombreDeRotation >= 101 && NombreDeRotation <= 108)
         {
            Categorie = "Culinaire";
            PopQuestion(Categorie);
         }

      }

      private void UpdateButton()
      {
         if (!rb1.Checked && !rb2.Checked && !rb3.Checked && !rb4.Checked)
         {
            button1.Enabled = false;
         }
         else
         {
            button1.Enabled = true;
         }
      }

      private void PopQuestion(String Catego)
      {
         player.Stop();
         FormQuestion question = new FormQuestion(oraconn, Catego, TourDe);
         question.StartPosition = FormStartPosition.CenterParent;
         question.ShowDialog();

         Score();
         if (Properties.Settings.Default.Win)
         {
            FinDePartie();
         }

         if (!Properties.Settings.Default.RepondreCorrectement)
         {
            ProchainJoueur();
            UpdateControls();
         }
      }

      private void FinDePartie()
      {
         PN_Win.Visible = true;
         LB_Gagnant.Text = TourDe + " à gagné !";
         LB_Nom.Text = Joueur1 + "\n" + Joueur2 + "\n" + Joueur3 + "\n" + Joueur4;

         string[,] tab = RemplirTableau();

         for (int i = 0; i < 4; i++)
         {
            LB_CatForte.Text += tab[i, 0] + "\n";
            LB_CatFaible.Text += tab[i, 1] + "\n";
         }
      }

      private string[,] RemplirTableau()
      {
         string[,] tableau = new string[4, 2];

         ///////// J1 //////////
         tableau[0, 0] = ComparerMeilleur(LB_J1_JeuxVideo.Text, LB_J1_Animaux.Text, LB_J1_Culinaire.Text, LB_J1_Musique.Text, Joueur1);
         tableau[0, 1] = ComparerFaible(LB_J1_JeuxVideo.Text, LB_J1_Animaux.Text, LB_J1_Culinaire.Text, LB_J1_Musique.Text, Joueur1, tableau[0, 0]);
         ///////// J2 //////////
         tableau[1, 0] = ComparerMeilleur(LB_J2_JeuxVideo.Text, LB_J2_Animaux.Text, LB_J2_Culinaire.Text, LB_J2_Musique.Text, Joueur2);
         tableau[1, 1] = ComparerFaible(LB_J2_JeuxVideo.Text, LB_J2_Animaux.Text, LB_J2_Culinaire.Text, LB_J2_Musique.Text, Joueur2, tableau[1, 0]);
         ///////// J3 //////////
         tableau[2, 0] = ComparerMeilleur(LB_J3_JeuxVideo.Text, LB_J3_Animaux.Text, LB_J3_Culinaire.Text, LB_J3_Musique.Text, Joueur3);
         tableau[2, 1] = ComparerFaible(LB_J3_JeuxVideo.Text, LB_J3_Animaux.Text, LB_J3_Culinaire.Text, LB_J3_Musique.Text, Joueur3, tableau[2, 0]);
         ///////// J4 //////////
         tableau[3, 0] = ComparerMeilleur(LB_J4_JeuxVideo.Text, LB_J4_Animaux.Text, LB_J4_Culinaire.Text, LB_J4_Musique.Text, Joueur4);
         tableau[3, 1] = ComparerFaible(LB_J4_JeuxVideo.Text, LB_J4_Animaux.Text, LB_J4_Culinaire.Text, LB_J4_Musique.Text, Joueur4, tableau[3, 0]);

         return tableau;
      }

      private string ComparerMeilleur(string Cat1, string Cat2, string Cat3, string Cat4, string nom)
      {
         string meilleur = "";

         if (nom != "")
         {
            if (Int32.Parse(Cat1) >= Int32.Parse(Cat2) && Int32.Parse(Cat1) >= Int32.Parse(Cat3) && Int32.Parse(Cat1) >= Int32.Parse(Cat4))
               meilleur = "Jeu Vidéo";
            else if (Int32.Parse(Cat2) >= Int32.Parse(Cat1) && Int32.Parse(Cat2) >= Int32.Parse(Cat3) && Int32.Parse(Cat2) >= Int32.Parse(Cat4))
               meilleur = "Animaux";
            else if (Int32.Parse(Cat3) >= Int32.Parse(Cat1) && Int32.Parse(Cat3) >= Int32.Parse(Cat2) && Int32.Parse(Cat3) >= Int32.Parse(Cat4))
               meilleur = "Culinaire";
            else
               meilleur = "Musique";
         }

         return meilleur;
      }

      private string ComparerFaible(string Cat1, string Cat2, string Cat3, string Cat4, string nom, string meilleur)
      {
         string faible = "";

         if (nom != "")
         {
            if (Int32.Parse(Cat1) <= Int32.Parse(Cat2) && Int32.Parse(Cat1) <= Int32.Parse(Cat3) && Int32.Parse(Cat1) <= Int32.Parse(Cat4) && meilleur != "Jeu Vidéo")
               faible = "Jeu Vidéo";
            else if (Int32.Parse(Cat2) <= Int32.Parse(Cat1) && Int32.Parse(Cat2) <= Int32.Parse(Cat3) && Int32.Parse(Cat2) <= Int32.Parse(Cat4) && meilleur != "Animaux")
               faible = "Animaux";
            else if (Int32.Parse(Cat3) <= Int32.Parse(Cat1) && Int32.Parse(Cat3) <= Int32.Parse(Cat2) && Int32.Parse(Cat3) <= Int32.Parse(Cat4) && meilleur != "Culinaire")
               faible = "Culinaire";
            else
               faible = "Musique";
         }

         return faible;
      }

      private void Score()
      {
         OracleCommand oraScore = new OracleCommand("GESTIONJOUER", oraconn);
         oraScore.CommandText = "GESTIONJOUER.ListerScore";
         oraScore.CommandType = CommandType.StoredProcedure;
         // pour une fonction, le paramètre de retour doit être déclaré en premier.
         OracleParameter paramScorecur = new OracleParameter("Score:", OracleDbType.RefCursor);
         paramScorecur.Direction = ParameterDirection.ReturnValue;

         // déclaration du paramètre en IN
         OracleParameter paramNomJoueur = new OracleParameter("NomJoueur:", OracleDbType.Varchar2);
         paramNomJoueur.Value = TourDe;
         paramNomJoueur.Direction = ParameterDirection.Input;

         oraScore.Parameters.Add(paramScorecur);
         oraScore.Parameters.Add(paramNomJoueur);

         OracleDataReader Oraread = oraScore.ExecuteReader();
         int i = 0;
         int[] List = new int[4];
         while (Oraread.Read())
         {
            List[i] = Oraread.GetInt32(0);
            i++;
         }

         if (TourDe == Joueur1)
         {
            LB_J1_Animaux.Text = List[0].ToString();
            LB_J1_Culinaire.Text = List[1].ToString();
            LB_J1_JeuxVideo.Text = List[2].ToString();
            LB_J1_Musique.Text = List[3].ToString();
         }
         else if (TourDe == Joueur2)
         {
            LB_J2_Animaux.Text = List[0].ToString();
            LB_J2_Culinaire.Text = List[1].ToString();
            LB_J2_JeuxVideo.Text = List[2].ToString();
            LB_J2_Musique.Text = List[3].ToString();
         }
         else if (TourDe == Joueur3)
         {
            LB_J3_Animaux.Text = List[0].ToString();
            LB_J3_Culinaire.Text = List[1].ToString();
            LB_J3_JeuxVideo.Text = List[2].ToString();
            LB_J3_Musique.Text = List[3].ToString();
         }
         else if (TourDe == Joueur4)
         {
            LB_J4_Animaux.Text = List[0].ToString();
            LB_J4_Culinaire.Text = List[1].ToString();
            LB_J4_JeuxVideo.Text = List[2].ToString();
            LB_J4_Musique.Text = List[3].ToString();
         }
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         if (compteur <= NombreDeRotation)
         {
            PB_Roulette.Image = RotateImageByAngle(conteneur, 10 * compteur);
            PB_Roulette.Refresh();
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
         Choix.Visible = false;

         Categorie = Choix.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

         PopQuestion(Categorie);
      }

      private void BTN_RevenirMenu_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void rb1_CheckedChanged(object sender, EventArgs e)
      {
         UpdateButton();
      }
   }
}
