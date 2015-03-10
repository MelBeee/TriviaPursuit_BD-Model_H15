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
   public partial class FormGestionJoueurs : Form
   {
      // variable contenant la connection a la bd 
      OracleConnection oraconn = new OracleConnection();
      bool SupprimerOuAjouter;

      public FormGestionJoueurs(OracleConnection oraconnPrincipale, bool JoueursDelAdd)
      {
         InitializeComponent();
         oraconn = oraconnPrincipale;
         SupprimerOuAjouter = JoueursDelAdd;
      }
      private void FormGestionJoueurs_Load(object sender, EventArgs e)
      {
         UpdateControl();
         if (SupprimerOuAjouter)
         {
            TB_NomJoueur.Visible = true;
            TB_NomJoueur.Enabled = true;
            CB_Joueurs.Visible = false;
            CB_Joueurs.Enabled = false;
         }
         else
         {
            TB_NomJoueur.Visible = false;
            TB_NomJoueur.Enabled = false;
            CB_Joueurs.Visible = true;
            CB_Joueurs.Enabled = true;
            RemplirCB();
         }
      }
      private bool Ajouter()
      {
         bool reussi = true;

         try
         {
            OracleCommand oraliste = new OracleCommand("GESTIONJOUEURS", oraconn);
            oraliste.CommandText = "GESTIONJOUEURS.INSERTIONJOUEUR";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter orapamNom = new OracleParameter("Username", OracleDbType.Varchar2, 20);
            orapamNom.Direction = ParameterDirection.Input;
            orapamNom.Value = TB_NomJoueur.Text;
            oraliste.Parameters.Add(orapamNom);

            oraliste.ExecuteNonQuery();
         }
         catch (OracleException ex)
         {
            reussi = false;
            GestionErreur(ex);
         }
         return reussi;
      }
      private bool Supprimer()
      {
         bool reussi = true;

         try
         {
            OracleCommand oraliste = new OracleCommand("GESTIONJOUEURS", oraconn);
            oraliste.CommandText = "GESTIONJOUEURS.SUPPRESSIONJOUEUR";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter orapamNum = new OracleParameter("Username", OracleDbType.Varchar2, 20);
            orapamNum.Direction = ParameterDirection.Input;
            orapamNum.Value = CB_Joueurs.SelectedItem.ToString();
            oraliste.Parameters.Add(orapamNum);

            oraliste.ExecuteNonQuery();
         }
         catch (OracleException ex)
         {
            reussi = false;
            GestionErreur(ex);
         }

         return reussi;
      }
      private void RemplirCB()
      {
         CB_Joueurs.Items.Clear();

         try
         {
            OracleCommand oraliste = new OracleCommand("GESTIONJOUEURS", oraconn);
            oraliste.CommandText = "GESTIONJOUEURS.LISTERJOUEURS";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter liste = new OracleParameter("liste", OracleDbType.RefCursor);
            liste.Direction = ParameterDirection.ReturnValue;

            oraliste.Parameters.Add(liste);
            OracleDataReader oraRead = oraliste.ExecuteReader();

            while (oraRead.Read())
            {
               CB_Joueurs.Items.Add(oraRead.GetString(0));
            }

            oraRead.Close();
            if (CB_Joueurs.Items.Count > 0)
               CB_Joueurs.SelectedIndex = 0;
         }
         catch (OracleException ex)
         {
            GestionErreur(ex);
         }
      }
      private void BTN_Annuler_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      private void BTN_Appliquer_Click(object sender, EventArgs e)
      {
         if (SupprimerOuAjouter)
         {
            if (Ajouter())
            {
               MessageBox.Show("Insertion reussite");
               TB_NomJoueur.Text = "";
            }
            else
            {
               MessageBox.Show("Insertion non reussite");
            }
         }
         else
         {
            if (Supprimer())
               MessageBox.Show("Suppression reussite");
            else
               MessageBox.Show("Suppression non reussite");
            RemplirCB();
         }
         UpdateControl();
      }
      private void UpdateControl()
      {
         BTN_Appliquer.Enabled = false;
         if (SupprimerOuAjouter)
         {
            if (TB_NomJoueur.Text != "")
               BTN_Appliquer.Enabled = true;
         }
         else
         {
            if (CB_Joueurs.Text != "")
               BTN_Appliquer.Enabled = true;
         }
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

      private void TB_NomJoueur_TextChanged(object sender, EventArgs e)
      {
         UpdateControl();
      }

      private void CB_Joueurs_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateControl();
      }

   }
}
