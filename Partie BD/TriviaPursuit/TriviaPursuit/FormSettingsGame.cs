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
         oraconn = oraconnPrincipale;
      }

      private bool VerificationJoueur(string NomJoueur)
      {
         bool Existe = false;
         string nom;
         try
         {

            OracleCommand VerificationJoueur = new OracleCommand("GESTIONJOUER", oraconn);
            VerificationJoueur.CommandText = "GESTIONJOUER.RECHERCHEJOUEUR";
            VerificationJoueur.CommandType = CommandType.StoredProcedure;

            OracleParameter OrapamNom = new OracleParameter("Nom", OracleDbType.Varchar2, 20);
            OrapamNom.Direction = ParameterDirection.Input;
            OrapamNom.Value = NomJoueur;
            VerificationJoueur.Parameters.Add(OrapamNom);           

            OracleParameter JoueurExiste = new OracleParameter("Existe", OracleDbType.Varchar2);
            JoueurExiste.Direction = ParameterDirection.ReturnValue;
            VerificationJoueur.Parameters.Add(JoueurExiste);


            nom = VerificationJoueur.ExecuteScalar().ToString();
           
            if (nom == "true")
               Existe=true;        
               
         }
         catch (OracleException ex)
         {
            GestionErreur(ex);
            
         }
         return Existe;
        
      }

      private void TesterVide(string Nom, int nombre)
      {
         if (Nom != "")
            if (VerificationJoueur(Nom))
               nombre++;
            else
               MessageBox.Show("Le nom " + Nom + " n'existe pas.");
      }

      private void BTN_Start_Click(object sender, EventArgs e)
      {
         int nbre = 0;

         TesterVide(TB_P1.Text, nbre);
         TesterVide(TB_P2.Text, nbre);
         TesterVide(TB_P3.Text, nbre);
         TesterVide(TB_P4.Text, nbre);

         if (nbre >= 2)
         {
            FormJeu form = new FormJeu(oraconn);

            if (form.ShowDialog() == DialogResult.Abort)
               this.Close();
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
