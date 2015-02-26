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
   public partial class Menu : Form
   {
      public Menu()
      {
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void Menu_Load(object sender, EventArgs e)
      {

      }

      private void label1_MouseMove(object sender, MouseEventArgs e)
      {
         label1.ForeColor = Color.Black;
      }

      private void label1_MouseLeave(object sender, EventArgs e)
      {
         label1.ForeColor = Color.White;
      }

      private void label1_MouseDown(object sender, MouseEventArgs e)
      {
         label1.ForeColor = Color.Gray;
      }
   }
}
