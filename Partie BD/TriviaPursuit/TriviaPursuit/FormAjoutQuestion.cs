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
   public partial class FormAjoutQuestion : Form
   {
      // variable contenant la connection a la bd 
      OracleConnection oraconn = new OracleConnection();

      public FormAjoutQuestion(OracleConnection oraconnPrincipale)
      {
         InitializeComponent();
         oraconn = oraconnPrincipale;
      }

      private void BTN_Annuler_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      private void UpdateControls()
      {
         if(TB_CHOIX1.Text ==""  || TB_CHOIX2.Text =="" || TB_CHOIX3.Text == "" || TB_QUESTION.Text =="" || TB_REPONSE.Text == "")
         {
            BTN_Ajouter.Enabled = false;
         }
         else
         {
            BTN_Ajouter.Enabled = true;
         }
      }

      private void FormAjoutQuestion_Load(object sender, EventArgs e)
      {
         ClearTextBoxAjouter();
         UpdateControls();
      }
      private void ClearTextBoxAjouter()
      {
         TB_QUESTION.Text = "";
         TB_REPONSE.Text = "";
         TB_CHOIX1.Text = "";
         TB_CHOIX2.Text = "";
         TB_CHOIX3.Text = "";
         CB_CATEGORIE.SelectedIndex = 0;        
      }
      private void GestionErreur(OracleException ex)
      {
         FormErreur form = new FormErreur(ex);

         if (form.ShowDialog() == DialogResult.Abort)
         {
            this.DialogResult = DialogResult.Abort;
         }
      }

      private void BTN_Ajouter_Click(object sender, EventArgs e)
      {
         try
         {
            OracleCommand CMDAJOUT = new OracleCommand("CMDAJOUT", oraconn);
            CMDAJOUT.CommandType = CommandType.StoredProcedure;
            CMDAJOUT.CommandText = "GESTIONQUESTIONS.INSERTIONQUESTIONS";           

            OracleParameter DESCRIPTION = new OracleParameter("DESCRIPTION:", OracleDbType.Varchar2, 120);
            DESCRIPTION.Direction = ParameterDirection.Input;
            DESCRIPTION.Value = TB_QUESTION.Text;
            CMDAJOUT.Parameters.Add(DESCRIPTION);

            OracleParameter CHOIX1 = new OracleParameter("CHOIX1:", OracleDbType.Varchar2, 80);
            CHOIX1.Direction = ParameterDirection.Input;
            CHOIX1.Value = TB_CHOIX1.Text;
            CMDAJOUT.Parameters.Add(CHOIX1);

            OracleParameter CHOIX2 = new OracleParameter("CHOIX2:", OracleDbType.Varchar2, 80);
            CHOIX2.Direction = ParameterDirection.Input;
            CHOIX2.Value = TB_CHOIX2.Text;
            CMDAJOUT.Parameters.Add(CHOIX2);

            OracleParameter CHOIX3 = new OracleParameter("CHOIX3:", OracleDbType.Varchar2, 80);
            CHOIX3.Direction = ParameterDirection.Input;
            CHOIX3.Value = TB_CHOIX3.Text;
            CMDAJOUT.Parameters.Add(CHOIX3);          

            OracleParameter REPONSE = new OracleParameter("REPONSE:", OracleDbType.Varchar2, 80);
            REPONSE.Direction = ParameterDirection.Input;
            REPONSE.Value = TB_REPONSE.Text;
            CMDAJOUT.Parameters.Add(REPONSE);

            OracleParameter NOMCATEGORIE = new OracleParameter("CATEGORIE:", OracleDbType.Varchar2, 40);
            NOMCATEGORIE.Direction = ParameterDirection.Input;
            NOMCATEGORIE.Value = CB_CATEGORIE.SelectedItem.ToString();
            CMDAJOUT.Parameters.Add(NOMCATEGORIE);

            CMDAJOUT.ExecuteNonQuery();
            ClearTextBoxAjouter();
           

         }
         catch (OracleException ex)
         {
            GestionErreur(ex);
         }
      }

      private void TB_QUESTION_TextChanged(object sender, EventArgs e)
      {
         UpdateControls();
      }

      private void TB_REPONSE_TextChanged(object sender, EventArgs e)
      {
         UpdateControls();
      }

      private void TB_CHOIX1_TextChanged(object sender, EventArgs e)
      {
         UpdateControls();
      }

      private void TB_CHOIX2_TextChanged(object sender, EventArgs e)
      {
         UpdateControls();
      }

      private void TB_CHOIX3_TextChanged(object sender, EventArgs e)
      {
         UpdateControls();
      }
   }
}
