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
      int IDQuestion; 

      public FormQuestion(OracleConnection oraconnPrincipale, string Categorie, string Joueur)
      {
         InitializeComponent();
         oraconn = oraconnPrincipale;
         NomCategorie = Categorie;
         NomJoueur = Joueur; 
      }

      private void GetQuestionAleatoire()
      {

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
         Reponse = LB_Choix2.Text;
         AnalyseReponse();
      }

      private void LB_Choix3_Click(object sender, EventArgs e)
      {
         Reponse = LB_Choix3.Text;
         AnalyseReponse();
      }

      private void LB_Choix4_Click(object sender, EventArgs e)
      {
         Reponse = LB_Choix4.Text;
         AnalyseReponse();
      }

      private void LB_Choix1_Click(object sender, EventArgs e)
      {
         Reponse = LB_Choix1.Text;
         AnalyseReponse();
      }

      private void AnalyseReponse()
      {
         bool bonnerep = true;
         PN_MSGRep.Visible = true;
         if (bonnerep)
         {
            LB_MSGRep.Text = "Bonne réponse !";
            SonQuestionGagne();
            AjoutQuestionGagnee();
         }
         else
         {
            LB_MSGRep.Text = "Mauvaise réponse !";
            SonQuestionPerdu();
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


/*
  select q.idquestion from questions q
  where q.idquestion not in 
  (select idquestion from questionreussie where NOMJOUEUR = 'MelBeee') 
  AND nomcategorie = 'Culinaire';
  */