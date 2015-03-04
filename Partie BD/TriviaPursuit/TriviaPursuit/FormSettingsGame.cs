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

      private void BTN_Start_Click(object sender, EventArgs e)
      {
         FormJeu form = new FormJeu(oraconn);

         if( form.ShowDialog() == DialogResult.Abort)
            this.Close();
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
