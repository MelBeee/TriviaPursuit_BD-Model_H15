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
   public partial class FormSupressionQuestion : Form
   {
      // variable contenant la connection a la bd 
      OracleConnection oraconn = new OracleConnection();
      private DataSet monDataSet = new DataSet();
      public FormSupressionQuestion(OracleConnection oraconnPrincipale)
      {
         InitializeComponent();
         oraconn = oraconnPrincipale;
      }

      private void Lister()
      {
         BTN_PRECEDENT.Enabled = false;
         BTN_SUIVANT.Enabled = false;
         try
         {
            BTN_PRECEDENT.Enabled = false;

            monDataSet.Clear();
            ViderLabel();
            OracleCommand oraliste = new OracleCommand("GESTIONQUESTIONS", oraconn);
            oraliste.CommandText = "GESTIONQUESTIONS.LISTER";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter liste = new OracleParameter("liste", OracleDbType.RefCursor);
            liste.Direction = ParameterDirection.ReturnValue;

            OracleParameter NOMCATEGORIE = new OracleParameter("NOMCATEGORIE", OracleDbType.Varchar2, 20);
            NOMCATEGORIE.Direction = ParameterDirection.Input;
            NOMCATEGORIE.Value = CB_CATEGORIE.SelectedItem.ToString();

            oraliste.Parameters.Add(liste);
            oraliste.Parameters.Add(NOMCATEGORIE);

            OracleDataAdapter orAdater = new OracleDataAdapter(oraliste);
            if (monDataSet.Tables.Contains("Lister"))
            {
               monDataSet.Tables["Lister"].Clear();
            }
            orAdater.Fill(monDataSet, "Lister");
            oraliste.Dispose();
            if (this.BindingContext[monDataSet, "Lister"].Count > 0)
            {
               RemplirLabel();
               BTN_Supprimer.Enabled = true;
            }
            else
            {
               MessageBox.Show("Il n'y a pas de question dans cette catégorie");
               ViderLabel();
               BTN_Supprimer.Enabled = false;
            }
            if (this.BindingContext[monDataSet, "Lister"].Count > 1)
            {
               BTN_SUIVANT.Enabled = true;
            }

         }
         catch (OracleException ex)
         {
            GestionErreur(ex);
         }
      }
      private void GestionErreur(OracleException ex)
      {
         FormErreur form = new FormErreur(ex);

         if (form.ShowDialog() == DialogResult.Abort)
         {
            this.Close();
         }
      }
      private void RemplirLabel()
      {
         LB_ID.DataBindings.Add("Text", monDataSet, "lister.IDQUESTION");
         LB_QUESTION.DataBindings.Add("Text", monDataSet, "lister.DESCRIPTION");
         LB_REPONSE.DataBindings.Add("Text", monDataSet, "lister.REPONSE");
         LB_CHOIX1.DataBindings.Add("Text", monDataSet, "lister.CHOIX1");
         LB_CHOIX2.DataBindings.Add("Text", monDataSet, "lister.CHOIX2");
         LB_CHOIX3.DataBindings.Add("Text", monDataSet, "lister.CHOIX3");
      }
      private void ViderLabel()
      {
         LB_ID.DataBindings.Clear();
         LB_QUESTION.DataBindings.Clear();
         LB_REPONSE.DataBindings.Clear();
         LB_CHOIX1.DataBindings.Clear();
         LB_CHOIX2.DataBindings.Clear();
         LB_CHOIX3.DataBindings.Clear();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void CB_CATEGORIE_SelectedIndexChanged(object sender, EventArgs e)
      {
         BTN_PRECEDENT.Enabled = false;
         BTN_SUIVANT.Enabled = false;
         Lister();
      }

      private void BTN_SUIVANT_Click(object sender, EventArgs e)
      {
         BTN_PRECEDENT.Enabled = true;
        
         this.BindingContext[monDataSet, "Lister"].Position += 1;
         if (this.BindingContext[monDataSet, "Lister"].Position.ToString() == (this.BindingContext[monDataSet, "Lister"].Count - 1).ToString())
         {
            BTN_SUIVANT.Enabled = false;
         }               
      }

      private void BTN_PRECEDENT_Click(object sender, EventArgs e)
      {
         BTN_SUIVANT.Enabled = true;       
         this.BindingContext[monDataSet, "Lister"].Position -= 1;
         if (this.BindingContext[monDataSet, "Lister"].Position.ToString() == "0")
         {
            BTN_PRECEDENT.Enabled = false;
         }         
      }

      private void FormSupressionQuestion_Load(object sender, EventArgs e)
      {
         CB_CATEGORIE.SelectedIndex = 0;
         Lister();
         BTN_PRECEDENT.Enabled = false;
         BTN_SUIVANT.Enabled = false;
      }

      private void BTN_Supprimer_Click(object sender, EventArgs e)
      {
         try
         {

            OracleCommand oraliste = new OracleCommand("GESTIONQUESTIONS", oraconn);
            oraliste.CommandText = "GESTIONQUESTIONS.SUPPRIMERQUESTIONS";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter IDQUESTION = new OracleParameter("IDQUESTION", OracleDbType.Int32);
            IDQUESTION.Direction = ParameterDirection.Input;
            IDQUESTION.Value = LB_ID.Text;
            oraliste.Parameters.Add(IDQUESTION);

            oraliste.ExecuteNonQuery();
           
         }
         catch (OracleException ex)
         {
            GestionErreur(ex);
         }
         Lister();      
      }
   }
}
