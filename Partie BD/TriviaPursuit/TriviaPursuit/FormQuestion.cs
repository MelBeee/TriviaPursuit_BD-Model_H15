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
   public partial class FormQuestion : Form
   {
      public FormQuestion()
      {
         InitializeComponent();
      }

      private void LB_Choix1_MouseLeave(object sender, EventArgs e)
      {
         LB_Choix1.ForeColor = Color.Black;
         LB_Choix1.BackColor = Color.PaleGoldenrod;
         Cursor.Current = Cursors.Arrow;
      }

      private void LB_Choix1_MouseMove(object sender, MouseEventArgs e)
      {
         LB_Choix1.ForeColor = Color.PaleGoldenrod;
         LB_Choix1.BackColor = Color.Black;
         Cursor.Current = Cursors.Hand;
      }

      private void LB_Choix2_MouseLeave(object sender, EventArgs e)
      {
         LB_Choix2.ForeColor = Color.Black;
         LB_Choix2.BackColor = Color.PaleGoldenrod;
         Cursor.Current = Cursors.Arrow;
      }

      private void LB_Choix2_MouseMove(object sender, MouseEventArgs e)
      {
         LB_Choix2.ForeColor = Color.PaleGoldenrod;
         LB_Choix2.BackColor = Color.Black;
         Cursor.Current = Cursors.Hand;
      }

      private void LB_Choix3_MouseLeave(object sender, EventArgs e)
      {
         LB_Choix3.ForeColor = Color.Black;
         LB_Choix3.BackColor = Color.PaleGoldenrod;
         Cursor.Current = Cursors.Arrow;
      }

      private void LB_Choix3_MouseMove(object sender, MouseEventArgs e)
      {
         LB_Choix3.ForeColor = Color.PaleGoldenrod;
         LB_Choix3.BackColor = Color.Black;
         Cursor.Current = Cursors.Hand;
      }

      private void LB_Choix4_MouseLeave(object sender, EventArgs e)
      {
         LB_Choix4.ForeColor = Color.Black;
         LB_Choix4.BackColor = Color.PaleGoldenrod;
         Cursor.Current = Cursors.Arrow;
      }

      private void LB_Choix4_MouseMove(object sender, MouseEventArgs e)
      {
         LB_Choix4.ForeColor = Color.PaleGoldenrod;
         LB_Choix4.BackColor = Color.Black;
         Cursor.Current = Cursors.Hand;
      }

      private void FormQuestion_Load(object sender, EventArgs e)
      {

      }

      private void LB_Choix2_Click(object sender, EventArgs e)
      {

      }

      private void LB_Choix3_Click(object sender, EventArgs e)
      {

      }

      private void LB_Choix4_Click(object sender, EventArgs e)
      {

      }

      private void LB_Choix1_Click(object sender, EventArgs e)
      {

      }
   }
}
