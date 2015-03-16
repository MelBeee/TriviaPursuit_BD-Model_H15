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

namespace TriviaPursuit
{
   public partial class FormQuestion : Form
   {
      // variable contenant la connection a la bd 
      OracleConnection oraconn = new OracleConnection();
      string NomCategorie;
      string NomJoueur;
      string Reponse;
      string ReponseDonnee;
      int IDQuestion;
      string Question;
      string Choix1;
      string Choix2;
      string Choix3;

      public FormQuestion(OracleConnection oraconnPrincipale, string Categorie, string Joueur)
      {
         InitializeComponent();
         oraconn = oraconnPrincipale;
         NomCategorie = Categorie;
         NomJoueur = Joueur; 
      }

      private void GetQuestionAleatoire()
      {
          try
          {
              OracleCommand cmdQAleatoire = new OracleCommand("GESTIONJOUER", oraconn);
              cmdQAleatoire.CommandType = CommandType.StoredProcedure;
              cmdQAleatoire.CommandText = "GESTIONJOUER.GetQuestionAleatoire";

              OracleParameter paramQuestion = new OracleParameter("IDQuestion:", OracleDbType.Int32);
              paramQuestion.Direction = ParameterDirection.ReturnValue;

              OracleParameter paramJoueur = new OracleParameter("NomJoueur:", OracleDbType.Varchar2, 20);
              paramJoueur.Direction = ParameterDirection.Input;
              paramJoueur.Value = NomJoueur;

              OracleParameter paramCategorie = new OracleParameter("Categorie:", OracleDbType.Varchar2, 20);
              paramCategorie.Direction = ParameterDirection.Input;
              paramCategorie.Value = NomCategorie;

              cmdQAleatoire.Parameters.Add(paramQuestion);
              cmdQAleatoire.Parameters.Add(paramJoueur);
              cmdQAleatoire.Parameters.Add(paramCategorie);

              cmdQAleatoire.ExecuteScalar();
              IDQuestion = Int32.Parse(paramQuestion.Value.ToString());

              /////////////////////////////////////////////////////////////

              OracleCommand oraliste = new OracleCommand("GESTIONJOUER", oraconn);
              oraliste.CommandText = "GESTIONJOUER.LISTERQuestion";
              oraliste.CommandType = CommandType.StoredProcedure;
              // pour une fonction, le paramètre de retour doit être déclaré en premier.
               OracleParameter paramQuestionCur = new OracleParameter("Question:", OracleDbType.RefCursor);
               paramQuestionCur.Direction = ParameterDirection.ReturnValue;
              
              // déclaration du paramètre en IN
              OracleParameter paramIDQuestion = new OracleParameter("IDQuestion:", OracleDbType.Int32);
              paramIDQuestion.Value = IDQuestion;
              paramIDQuestion.Direction = ParameterDirection.Input;

              oraliste.Parameters.Add(paramQuestionCur);
              oraliste.Parameters.Add(paramIDQuestion);

              OracleDataReader Oraread = oraliste.ExecuteReader();

              Oraread.Read();
              Choix1 = Oraread.GetString(0);
              Choix2 = Oraread.GetString(1);
              Choix3 = Oraread.GetString(2);
              Question = Oraread.GetString(3);
              Reponse = Oraread.GetString(4);

              SetUpQuestion();
          }
          catch (OracleException ex)
          {
              GestionErreur(ex);
          }
      }

      private void SetUpQuestion()
      {
          int chiffrerandom;
          Random chiffre = new Random();
          chiffrerandom = chiffre.Next(6);
          LB_Description.Text = Question;

          switch(chiffrerandom)
          {
              case 0:
                  LB_Choix1.Text = Choix1;
                  LB_Choix2.Text = Choix2;
                  LB_Choix3.Text = Choix3;
                  LB_Choix4.Text = Reponse;
                  break;
              case 1:
                  LB_Choix1.Text = Choix2;
                  LB_Choix2.Text = Choix3;
                  LB_Choix3.Text = Reponse;
                  LB_Choix4.Text = Choix1;
                  break;
              case 2:
                  LB_Choix1.Text = Choix3;
                  LB_Choix2.Text = Reponse;
                  LB_Choix3.Text = Choix1;
                  LB_Choix4.Text = Choix2;
                  break;
              case 3:
                  LB_Choix1.Text = Reponse;
                  LB_Choix2.Text = Choix1;
                  LB_Choix3.Text = Choix2;
                  LB_Choix4.Text = Choix3;
                  break;
              case 4:
                  LB_Choix1.Text = Choix1;
                  LB_Choix2.Text = Reponse;
                  LB_Choix3.Text = Choix3;
                  LB_Choix4.Text = Choix2;
                  break;
              case 5:
                  LB_Choix1.Text = Reponse;
                  LB_Choix2.Text = Choix3;
                  LB_Choix3.Text = Choix2;
                  LB_Choix4.Text = Choix1;
                  break;
              default:
                  LB_Choix1.Text = Choix1;
                  LB_Choix2.Text = Choix2;
                  LB_Choix3.Text = Choix3;
                  LB_Choix4.Text = Reponse;
                  break;
          }
      }

      private void LB_Choix1_MouseLeave(object sender, EventArgs e)
      {
         LB_Choix1.ForeColor = Color.Black;
         LB_Choix1.BackColor = Color.PaleGoldenrod;
         Cursor.Current = Cursors.Arrow;
      }

      private void LB_Choix1_MouseMove(object sender, MouseEventArgs e)
      {
         LB_Choix1.ForeColor = Color.PaleGoldenrod;
         LB_Choix1.BackColor = Color.Black;
         Cursor.Current = Cursors.Hand;
      }

      private void LB_Choix2_MouseLeave(object sender, EventArgs e)
      {
         LB_Choix2.ForeColor = Color.Black;
         LB_Choix2.BackColor = Color.PaleGoldenrod;
         Cursor.Current = Cursors.Arrow;
      }

      private void LB_Choix2_MouseMove(object sender, MouseEventArgs e)
      {
         LB_Choix2.ForeColor = Color.PaleGoldenrod;
         LB_Choix2.BackColor = Color.Black;
         Cursor.Current = Cursors.Hand;
      }

      private void LB_Choix3_MouseLeave(object sender, EventArgs e)
      {
         LB_Choix3.ForeColor = Color.Black;
         LB_Choix3.BackColor = Color.PaleGoldenrod;
         Cursor.Current = Cursors.Arrow;
      }

      private void LB_Choix3_MouseMove(object sender, MouseEventArgs e)
      {
         LB_Choix3.ForeColor = Color.PaleGoldenrod;
         LB_Choix3.BackColor = Color.Black;
         Cursor.Current = Cursors.Hand;
      }

      private void LB_Choix4_MouseLeave(object sender, EventArgs e)
      {
         LB_Choix4.ForeColor = Color.Black;
         LB_Choix4.BackColor = Color.PaleGoldenrod;
         Cursor.Current = Cursors.Arrow;
      }

      private void LB_Choix4_MouseMove(object sender, MouseEventArgs e)
      {
         LB_Choix4.ForeColor = Color.PaleGoldenrod;
         LB_Choix4.BackColor = Color.Black;
         Cursor.Current = Cursors.Hand;
      }

      private void FormQuestion_Load(object sender, EventArgs e)
      {
         GetQuestionAleatoire();
      }

      private void LB_Choix2_Click(object sender, EventArgs e)
      {
          ReponseDonnee = LB_Choix2.Text;
         AnalyseReponse();
      }

      private void LB_Choix3_Click(object sender, EventArgs e)
      {
          ReponseDonnee = LB_Choix3.Text;
         AnalyseReponse();
      }

      private void LB_Choix4_Click(object sender, EventArgs e)
      {
          ReponseDonnee = LB_Choix4.Text;
         AnalyseReponse();
      }

      private void LB_Choix1_Click(object sender, EventArgs e)
      {
          ReponseDonnee = LB_Choix1.Text;
         AnalyseReponse();
      }

      private void AnalyseReponse()
      {
         PN_MSGRep.Visible = true;
         if (ReponseDonnee == Reponse)
         {
            LB_MSGRep.Text = "Bonne réponse !";
            SonQuestionGagne();
            AjoutQuestionGagnee();
            AjoutCategorie();
            Properties.Settings.Default.RepondreCorrectement = true;
            Properties.Settings.Default.Save();
         }
         else
         {
            LB_MSGRep.Text = "Mauvaise réponse !";
            SonQuestionPerdu();
            Properties.Settings.Default.RepondreCorrectement = false;
            Properties.Settings.Default.Save();
         }
      }

      private void AjoutCategorie()
      {
         try
         {
            OracleCommand CMDAJOUT = new OracleCommand("CMDAJOUT", oraconn);
            CMDAJOUT.CommandType = CommandType.StoredProcedure;
            CMDAJOUT.CommandText = "GESTIONJOUER.UpdateCategorie";

            OracleParameter paramCategorie = new OracleParameter("IDQuestion:", OracleDbType.Varchar2, 20);
            paramCategorie.Direction = ParameterDirection.Input;
            paramCategorie.Value = NomCategorie;

            OracleParameter paramJoueur = new OracleParameter("pnomcat:", OracleDbType.Varchar2, 20);
            paramJoueur.Direction = ParameterDirection.Input;
            paramJoueur.Value = NomJoueur;

            CMDAJOUT.Parameters.Add(paramCategorie);
            CMDAJOUT.Parameters.Add(paramJoueur);

            CMDAJOUT.ExecuteNonQuery();
         }
         catch (OracleException ex)
         {
            GestionErreur(ex);
         }
      }

      private void AjoutQuestionGagnee()
      {
         try
         {
            OracleCommand CMDAJOUT = new OracleCommand("CMDAJOUT", oraconn);
            CMDAJOUT.CommandType = CommandType.StoredProcedure;
            CMDAJOUT.CommandText = "GESTIONJOUER.AjoutQuestionReussite";

            OracleParameter paramJoueur = new OracleParameter("NomJoueur:", OracleDbType.Varchar2, 20);
            paramJoueur.Direction = ParameterDirection.Input;
            paramJoueur.Value = NomJoueur;

            OracleParameter paramQuestion = new OracleParameter("IDQuestion:", OracleDbType.Int32);
            paramQuestion.Direction = ParameterDirection.Input;
            paramQuestion.Value = IDQuestion.ToString();

            CMDAJOUT.Parameters.Add(paramJoueur);
            CMDAJOUT.Parameters.Add(paramQuestion);

            CMDAJOUT.ExecuteNonQuery();
         }
         catch (OracleException ex)
         {
            GestionErreur(ex);
         }
      }

      private void BTN_Continuer_Click(object sender, EventArgs e)
      {
         this.Close();
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

      private void SonQuestionGagne()
      {
          var player = new System.Media.SoundPlayer();
          player.Stream = Properties.Resources.QuestionReussite;
          player.Play();
      }

      private void SonQuestionPerdu()
      {
          var player = new System.Media.SoundPlayer();
          player.Stream = Properties.Resources.QuestionEchouee;
          player.Play();
      }
   }
}


