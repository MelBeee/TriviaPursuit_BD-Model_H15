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
   public partial class FormJeu : Form
   {
      // variable contenant la connection a la bd 
      OracleConnection oraconn = new OracleConnection();

      public FormJeu(OracleConnection oraconnPrincipale)
      {
         InitializeComponent();
         oraconn = oraconnPrincipale;
      }

      private void BTN_Surrender_Click(object sender, EventArgs e)
      {

      }

      private void FormJeu_Load(object sender, EventArgs e)
      {

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
   }
}
