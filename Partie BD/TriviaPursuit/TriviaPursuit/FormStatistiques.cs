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
   public partial class FormStatistiques : Form
   {
      // variable contenant la connection a la bd 
      OracleConnection oraconn = new OracleConnection();

      public FormStatistiques(OracleConnection oraconnPrincipale)
      {
         InitializeComponent();
         oraconn = oraconnPrincipale;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {
         var player = new System.Media.SoundPlayer();
         player.Stream = Properties.Resources.Typing;
         player.Play();
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
