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
   public partial class FormAjoutQuestion : Form
   {
      public FormAjoutQuestion()
      {
         InitializeComponent();
      }

      private void BTN_Annuler_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
