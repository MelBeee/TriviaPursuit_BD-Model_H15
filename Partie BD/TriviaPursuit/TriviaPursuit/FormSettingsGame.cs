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
   public partial class FormSettingsGame : Form
   {
      // variable contenant la connection a la bd 
      OracleConnection oraconn = new OracleConnection();

      public FormSettingsGame(OracleConnection oraconnPrincipale)
      {
         InitializeComponent();
         this.StartPosition = FormStartPosition.CenterParent;
         oraconn = oraconnPrincipale;
      }

      private bool VerificationJoueur(string NomJoueur)
      {
         bool Existe = false;
         string nombre;
         try
         {
            OracleCommand VerificationJoueur = new OracleCommand("GESTIONJOUER", oraconn);
            VerificationJoueur.CommandText = "GESTIONJOUER.RECHERCHEJOUEUR";
            VerificationJoueur.CommandType = CommandType.StoredProcedure;

            OracleParameter OrapamNom = new OracleParameter("Nom", OracleDbType.Varchar2, 20);
            OrapamNom.Direction = ParameterDirection.Input;
            OrapamNom.Value = NomJoueur;
            VerificationJoueur.Parameters.Add(OrapamNom);

            OracleParameter JoueurExiste = new OracleParameter("Existe", OracleDbType.Int32);
            JoueurExiste.Direction = ParameterDirection.Output;
            VerificationJoueur.Parameters.Add(JoueurExiste);

            VerificationJoueur.ExecuteNonQuery();

            nombre = JoueurExiste.Value.ToString();

            if (nombre == "1")
               Existe = true;
         }
         catch (OracleException ex)
         {
            GestionErreur(ex);

         }
         return Existe;
      }
      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         switch (keyData)
         {
            case Keys.Enter:
               DebuterLeJeu();
               break;

         }
         return base.ProcessCmdKey(ref msg, keyData);        
      }

      private int TesterVide(string Nom, int nombre)
      {
         if (Nom != "")
            if (VerificationJoueur(Nom))
               nombre++;
            else
            {
               MessageBox.Show("Le nom " + Nom + " n'existe pas.");
               nombre = 0;
            }


         return nombre;
      }

      private void BTN_Start_Click(object sender, EventArgs e)
      {
         DebuterLeJeu();
      }
      private void DebuterLeJeu()
      {
         int nbre = 0;

         nbre = TesterVide(TB_P1.Text, nbre);
         nbre = TesterVide(TB_P2.Text, nbre);
         nbre = TesterVide(TB_P3.Text, nbre);
         nbre = TesterVide(TB_P4.Text, nbre);

         if (nbre >= 2)
         {
            SetterJoueur(nbre);
            FormJeu form = new FormJeu(oraconn, TB_P1.Text, TB_P2.Text, TB_P3.Text, TB_P4.Text);

            this.Hide();
            if (form.ShowDialog() == DialogResult.Abort)
               this.DialogResult = DialogResult.Abort;
            else
               this.Close();

         }
         else
         {
            MessageBox.Show("Il n'y a pas assez de joueurs pour jouer");
         }
      }

      private void SetterJoueur(int nbre)
      {
         if (nbre == 2)
         {
            if (TB_P1.Text == "" && TB_P2.Text == "")
            {
               TB_P1.Text = TB_P3.Text;
               TB_P2.Text = TB_P4.Text;
               TB_P3.Text = "";
               TB_P4.Text = "";
            }
            else if (TB_P1.Text == "" && TB_P3.Text != "")
            {
               TB_P1.Text = TB_P3.Text;
               TB_P3.Text = "";
            }
            else if (TB_P1.Text == "" && TB_P4.Text != "")
            {
               TB_P1.Text = TB_P4.Text;
               TB_P4.Text = "";
            }
            else if (TB_P2.Text == "" && TB_P3.Text != "")
            {
               TB_P2.Text = TB_P3.Text;
               TB_P3.Text = "";
            }
            else if (TB_P2.Text == "" && TB_P4.Text != "")
            {
               TB_P2.Text = TB_P4.Text;
               TB_P4.Text = "";
            }
         }
         else if (nbre == 3)
         {
            if (TB_P1.Text == "")
            {
               TB_P1.Text = TB_P4.Text;
               TB_P4.Text = "";
            }
            else if (TB_P2.Text == "")
            {
               TB_P2.Text = TB_P4.Text;
               TB_P4.Text = "";
            }
            else if (TB_P3.Text == "")
            {
               TB_P3.Text = TB_P4.Text;
               TB_P4.Text = "";
            }
         }
      }

      private void BTN_Cancel_Click(object sender, EventArgs e)
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
   }
}
