using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaPursuit
{
   public partial class FormSettingsGame : Form
   {
      public FormSettingsGame()
      {
         InitializeComponent();
      }

      private void BTN_Start_Click(object sender, EventArgs e)
      {
         FormJeu form = new FormJeu();

         if( form.ShowDialog() == DialogResult.Abort)
            this.Close();
      }

      private void BTN_Cancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
