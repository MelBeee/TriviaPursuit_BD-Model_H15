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
   public partial class FormAPropos : Form
   {
      public FormAPropos()
      {
         InitializeComponent();
      }

      private void BTN_Fermer_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {
         var player = new System.Media.SoundPlayer();
         player.Stream = Properties.Resources.ChienQuiJappe;
         player.Play();
      }

      private void BTN_Rules_Click(object sender, EventArgs e)
      {
          FormReglements form = new FormReglements();

          form.Show(); 
      }
   }
}
